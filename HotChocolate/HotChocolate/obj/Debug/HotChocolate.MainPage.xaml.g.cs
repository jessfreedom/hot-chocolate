// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace HotChocolate {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("/Users/jessfreedom/Downloads/HotChocolate/HotChocolate/HotChocolate/MainPage.xaml")]
    public partial class MainPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label Emotion;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.ActivityIndicator UploadingIndicator;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private global::Xamarin.Forms.Label Quote;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(MainPage));
            Emotion = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Label>(this, "Emotion");
            UploadingIndicator = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.ActivityIndicator>(this, "UploadingIndicator");
            Quote = global::Xamarin.Forms.NameScopeExtensions.FindByName <global::Xamarin.Forms.Label>(this, "Quote");
        }
    }
}