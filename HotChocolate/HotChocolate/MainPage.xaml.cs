using Plugin.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.ProjectOxford.Emotion;

namespace HotChocolate
{
    public partial class MainPage : ContentPage
    {
        List<gingerbeer> quotes;

        public MainPage()
        {
            InitializeComponent();
        }

		protected async override void OnAppearing()
		{
			List<gingerbeer> goodgoodquotes = await AzureManager.AzureManagerInstance.GetQuotes();
            quotes = goodgoodquotes;
			Random random = new Random();
			int randomNumber = random.Next(0, goodgoodquotes.Count);

			gingerbeer goodquote = goodgoodquotes[randomNumber];

			Quote.Text = goodquote.Quote;
		}

        private async void TakePicture_Clicked(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera avaliable.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                DefaultCamera = Plugin.Media.Abstractions.CameraDevice.Front,
                Directory = "Moodify",
                Name = $"{DateTime.UtcNow}.jpg",
                CompressionQuality = 92
            });

            if (file == null)
                return;

            try
            {
                UploadingIndicator.IsRunning = true;

                string emotionKey = "6c0c8dfee6f34aaeb9af834d4479425c";

                EmotionServiceClient emotionClient = new EmotionServiceClient(emotionKey);

                var result = await emotionClient.RecognizeAsync(file.GetStream());

                UploadingIndicator.IsRunning = false;

                string emotion = result[0].Scores.ToRankedList().First().Key;

                Emotion.Text = "You are " + emotion;


                foreach (gingerbeer x in quotes) {
                    if (x.Mood.ToLower().Contains(emotion.ToLower().Substring(0,3)) || x.Mood.ToLower().Equals(emotion.ToLower())){
                        Quote.Text = x.Quote;
                    }
                }

            }
            catch (Exception ex)
            {
             
            }

            //image.Source = ImageSource.FromStream(() =>
            //{
            //    var stream = file.GetStream();
            //    file.Dispose();
            //    return stream;
            //});
        }

        void Handle_ClickedAsync(object sender, System.EventArgs e)
        {
            var goodgoodquotes = quotes;
            Random random = new Random();
            int randomNumber = random.Next(0, goodgoodquotes.Count);

            gingerbeer goodquote = goodgoodquotes[randomNumber];

            Quote.Text = goodquote.Quote;
        }
    }
}
