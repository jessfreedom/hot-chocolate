using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotChocolate
{
    class AzureManager
    {
        private static AzureManager instance;
        private MobileServiceClient client;
        private IMobileServiceTable<gingerbeer> pumpwater;

        private AzureManager()
        {
            this.client = new MobileServiceClient("http://yogurtdrink.azurewebsites.net");
            this.pumpwater = this.client.GetTable<gingerbeer>();
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public async Task<List<gingerbeer>> GetQuotes()
        {
            return await this.pumpwater.ToListAsync();
        }

        public static AzureManager AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }

                return instance;
            }
        }
    }
}

