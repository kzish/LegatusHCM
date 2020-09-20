using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;

namespace BlazorClient.Client.Globals
{

    public class Globals
    {
        public static Blazored.LocalStorage.ILocalStorageService local_storage;

        public Globals(Blazored.LocalStorage.ILocalStorageService _local_storage)
        {
            local_storage = _local_storage;
        }
        public static async Task<string> GetAccessToken()
        {
            string access_token = await local_storage.GetItemAsync<string>("access_token");
            return access_token;
        }

    }


}
