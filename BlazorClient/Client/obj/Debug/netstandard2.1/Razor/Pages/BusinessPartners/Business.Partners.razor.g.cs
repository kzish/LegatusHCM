#pragma checksum "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\Pages\BusinessPartners\Business.Partners.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a8a6884f1c1129391b384a75e30fdb1a36e54d6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Client.Pages.BusinessPartners
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
#nullable restore
#line 21 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/BusinessPartners/All")]
    public partial class Business_Partners : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-12");
            __builder.AddMarkupContent(5, "\r\n\r\n        ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\Pages\BusinessPartners\Business.Partners.razor"
                                  message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => message = __value, message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\Pages\BusinessPartners\Business.Partners.razor"
                          ShowAlert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Show Alert");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\Pages\BusinessPartners\Business.Partners.razor"
       

    string message = "";

    private async Task ShowAlert()
    {
        await JsRuntime.InvokeVoidAsync("alert", message);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http_client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authentication_state_provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService local_storage { get; set; }
    }
}
#pragma warning restore 1591
