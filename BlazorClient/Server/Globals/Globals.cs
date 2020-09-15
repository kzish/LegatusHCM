using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClient.Server.Globals
{
    public class Globals
    {
        public static string Issuer = Audience;
        public static string Audience = "https://localhost:44345/";
        public static string Secret = "my_secret_oga12345678910111213141516";//minimum 16 chars
    }
}
