#pragma checksum "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\Pages\BusinessPartners\Business.Partners.CreateNew.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa103ee9d06ad7d835f9a08132b45a09b1c7c432"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/BusinessPartners/CreateNew")]
    public partial class Business_Partners_CreateNew : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""row"">
    <div class=""col-md-12"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body"">
                <h5 class=""card-title"">Simple table</h5>
                <table class=""mb-0 table"" style=""width:100%"" id=""example"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>First Name</th>
                            <th>Last Name</th>
                            <th>Username</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope=""row"">1</th>
                            <td>Mark</td>
                            <td>Otto</td>
                            <td>mdo</td>
                        </tr>
                        <tr>
                            <th scope=""row"">2</th>
                            <td>Jacob</td>
                            <td>Thornton</td>
                            <td>fatt</td>
                        </tr>
                        <tr>
                            <th scope=""row"">3</th>
                            <td>Larry</td>
                            <td>the Bird</td>
                            <td>twitter</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authentication_state_provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService local_storage { get; set; }
    }
}
#pragma warning restore 1591
