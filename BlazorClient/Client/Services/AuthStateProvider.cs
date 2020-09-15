using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BlazorClient.Services
{
    public class AuthStateProvider : AuthenticationStateProvider
    {


        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
           
            return new AuthenticationState(new ClaimsPrincipal(identity));
        }
    }
}
