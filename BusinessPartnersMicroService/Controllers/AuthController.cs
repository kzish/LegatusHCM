using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Text;
using BusinessPartnersMicroService.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;

namespace BusinessPartnersMicroService.Controllers
{
    [Route("LegatusHCM/api")]
    public class AuthController : Controller
    {


        /// <summary>
        /// client using client id and client secret to authenticate and recieve access_token
        /// Add { Bearer <access_token> } in header request of each subsequent request
        /// </summary>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <returns></returns>
        [HttpGet("RequestToken")]
        public async Task<JsonResult> RequestToken(string client_id = "test_user", string client_secret = "12345")
        {
            try
            {
                var http_client = new HttpClient();
                var discovery_document = await http_client.GetDiscoveryDocumentAsync(Globals.auth_endpoint);

                // Accept the configuration even if the issuer and endpoints don't match
                discovery_document.Policy.ValidateIssuerName = false;
                discovery_document.Policy.ValidateEndpoints = false;

                var token_client = new TokenClient(http_client,new TokenClientOptions() { 
                    Address=discovery_document.TokenEndpoint,
                    ClientId=client_id,
                    ClientSecret=client_secret
                });
                //RequestClientCredentialsAsync
                var token_response = await token_client.RequestClientCredentialsTokenAsync("api");
                if (token_response.IsError)
                {
                    return new JsonResult(token_response.Exception);
                }
                else
                {
                    return new JsonResult(token_response.Json);
                }
            }
            catch (Exception ex)
            {
                return new JsonResult(ex);
            }
        }


      
    }
}
