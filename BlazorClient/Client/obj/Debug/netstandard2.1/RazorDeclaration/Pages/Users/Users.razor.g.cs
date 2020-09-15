#pragma checksum "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\Pages\Users\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "101289498a1679d436128a52c527da58c35c0b39"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorClient.Client.Pages.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using BlazorClient.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using BlazorClient.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayoutUsers))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Users")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Users/All")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\Pages\Users\Users.razor"
       

    List<SystemUsers> users = new List<SystemUsers>();

    string modal_title = string.Empty;//title of the modal
    string modal_mode = string.Empty;//new or edit

    SystemUsers system_user = new SystemUsers();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            await base.OnInitializedAsync();
            var response1 = await http_client.GetAsync("/SystemUsers/Users");
            var response2 = await response1.Content.ReadAsStringAsync();
            dynamic json = JsonConvert.DeserializeObject(response2);
            if (json.res == "ok")
            {
                users = JsonConvert.DeserializeObject<SystemUsers>(json.data.ToString());
            }
            else
            {
                toastService.ShowError(json.data.ToString());
            }
        }
        catch (Exception ex)
        {
            toastService.ShowError(ex.Message);
        }
    }

    void ExecuteSubmitForm()
    {
        if (modal_mode == "new")
        {
            toastService.ShowSuccess("hassan");
        }
        else
        {
            toastService.ShowInfo("hassan");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http_client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authentication_state_provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService local_storage { get; set; }
    }
}
#pragma warning restore 1591