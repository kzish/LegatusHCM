#pragma checksum "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\Shared\MainLayoutBusinessPartners - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e8afa37c8f844b0f96326c12c6cc71bbe8daa10"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Client.Shared
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
    public partial class MainLayoutBusinessPartners___Copy : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page-wrapper default-theme sidebar-bg bg1 toggled");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<nav id=\"sidebar\" class=\"sidebar-wrapper\">\r\n        <div class=\"sidebar-content\">\r\n            \r\n            <div class=\"sidebar-item sidebar-brand\">\r\n                <a href=\"#\">pro sidebar</a>\r\n            </div>\r\n            \r\n            <div class=\"sidebar-item sidebar-header d-flex flex-nowrap\">\r\n                <div class=\"user-pic\">\r\n                    <img class=\"img-responsive img-rounded\" src=\"assets/img/user.jpg\" alt=\"User picture\">\r\n                </div>\r\n                <div class=\"user-info\">\r\n                    <span class=\"user-name\">\r\n                        Jhon\r\n                        <strong>Smith</strong>\r\n                    </span>\r\n                    <span class=\"user-role\">Administrator</span>\r\n                    <span class=\"user-status\">\r\n                        <i class=\"fa fa-circle\"></i>\r\n                        <span>Online</span>\r\n                    </span>\r\n                </div>\r\n            </div>\r\n            \r\n            <div class=\"sidebar-item sidebar-search\">\r\n                <div>\r\n                    <div class=\"input-group\">\r\n                        <input type=\"text\" class=\"form-control search-menu\" placeholder=\"Search...\">\r\n                        <div class=\"input-group-append\">\r\n                            <span class=\"input-group-text\">\r\n                                <i class=\"fa fa-search\" aria-hidden=\"true\"></i>\r\n                            </span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            \r\n            <div class=\" sidebar-item sidebar-menu\">\r\n                <ul>\r\n                    <li class=\"header-menu\">\r\n                        <span>General</span>\r\n                    </li>\r\n                    <li class=\"sidebar-dropdown\">\r\n                        <a href=\"#\" class=\"active\">\r\n                            <i class=\"fa fa-tachometer-alt\"></i>\r\n                            <span class=\"menu-text\">Dashboard</span>\r\n                            <span class=\"badge badge-pill badge-warning\">New</span>\r\n                        </a>\r\n                        <div class=\"sidebar-submenu\">\r\n                            <ul>\r\n                                <li>\r\n                                    <a href=\"#\">\r\n                                        Dashboard 1\r\n                                        <span class=\"badge badge-pill badge-success\">Pro</span>\r\n                                    </a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">Dashboard 2</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">Dashboard 3</a>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </li>\r\n                    <li class=\"sidebar-dropdown\">\r\n                        <a href=\"#\">\r\n                            <i class=\"fa fa-shopping-cart\"></i>\r\n                            <span class=\"menu-text\">Business Partners</span>\r\n                            <span class=\"badge badge-pill badge-danger\">3</span>\r\n                        </a>\r\n                        <div class=\"sidebar-submenu\">\r\n                            <ul>\r\n                                <li>\r\n                                    <a href=\"#\">\r\n                                        All\r\n\r\n                                    </a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">Categories</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">Credit cart</a>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </li>\r\n                    <li class=\"sidebar-dropdown\">\r\n                        <a href=\"#\">\r\n                            <i class=\"far fa-gem\"></i>\r\n                            <span class=\"menu-text\">Components</span>\r\n                        </a>\r\n                        <div class=\"sidebar-submenu\">\r\n                            <ul>\r\n                                <li>\r\n                                    <a href=\"#\">General</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">Panels</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">Tables</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">Icons</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">Forms</a>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </li>\r\n                    <li class=\"sidebar-dropdown\">\r\n                        <a href=\"#\">\r\n                            <i class=\"fa fa-chart-line\"></i>\r\n                            <span class=\"menu-text\">Charts</span>\r\n                        </a>\r\n                        <div class=\"sidebar-submenu\">\r\n                            <ul>\r\n                                <li>\r\n                                    <a href=\"#\">Pie chart</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">Line chart</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">Bar chart</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">Histogram</a>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </li>\r\n                    <li class=\"sidebar-dropdown\">\r\n                        <a href=\"#\">\r\n                            <i class=\"fa fa-globe\"></i>\r\n                            <span class=\"menu-text\">Maps</span>\r\n                        </a>\r\n                        <div class=\"sidebar-submenu\">\r\n                            <ul>\r\n                                <li>\r\n                                    <a href=\"#\">Google maps</a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">Open street map</a>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </li>\r\n                    <li class=\"header-menu\">\r\n                        <span>Extra</span>\r\n                    </li>\r\n                    <li>\r\n                        <a href=\"#\">\r\n                            <i class=\"fa fa-book\"></i>\r\n                            <span class=\"menu-text\">Documentation</span>\r\n                            <span class=\"badge badge-pill badge-primary\">Beta</span>\r\n                        </a>\r\n                    </li>\r\n                    <li>\r\n                        <a href=\"#\">\r\n                            <i class=\"fa fa-calendar\"></i>\r\n                            <span class=\"menu-text\">Calendar</span>\r\n                        </a>\r\n                    </li>\r\n                    <li>\r\n                        <a href=\"#\">\r\n                            <i class=\"fa fa-folder\"></i>\r\n                            <span class=\"menu-text\">Examples</span>\r\n                        </a>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n            \r\n        </div>\r\n        \r\n        <div class=\"sidebar-footer\">\r\n            <div class=\"dropdown\">\r\n\r\n                <a href=\"#\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                    <i class=\"fa fa-bell\"></i>\r\n                    <span class=\"badge badge-pill badge-warning notification\">3</span>\r\n                </a>\r\n                <div class=\"dropdown-menu notifications\" aria-labelledby=\"dropdownMenuMessage\">\r\n                    <div class=\"notifications-header\">\r\n                        <i class=\"fa fa-bell\"></i>\r\n                        Notifications\r\n                    </div>\r\n                    <div class=\"dropdown-divider\"></div>\r\n                    <a class=\"dropdown-item\" href=\"#\">\r\n                        <div class=\"notification-content\">\r\n                            <div class=\"icon\">\r\n                                <i class=\"fas fa-check text-success border border-success\"></i>\r\n                            </div>\r\n                            <div class=\"content\">\r\n                                <div class=\"notification-detail\">\r\n                                    Lorem ipsum dolor sit amet consectetur adipisicing\r\n                                    elit. In totam explicabo\r\n                                </div>\r\n                                <div class=\"notification-time\">\r\n                                    6 minutes ago\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n                    <a class=\"dropdown-item\" href=\"#\">\r\n                        <div class=\"notification-content\">\r\n                            <div class=\"icon\">\r\n                                <i class=\"fas fa-exclamation text-info border border-info\"></i>\r\n                            </div>\r\n                            <div class=\"content\">\r\n                                <div class=\"notification-detail\">\r\n                                    Lorem ipsum dolor sit amet consectetur adipisicing\r\n                                    elit. In totam explicabo\r\n                                </div>\r\n                                <div class=\"notification-time\">\r\n                                    Today\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n                    <a class=\"dropdown-item\" href=\"#\">\r\n                        <div class=\"notification-content\">\r\n                            <div class=\"icon\">\r\n                                <i class=\"fas fa-exclamation-triangle text-warning border border-warning\"></i>\r\n                            </div>\r\n                            <div class=\"content\">\r\n                                <div class=\"notification-detail\">\r\n                                    Lorem ipsum dolor sit amet consectetur adipisicing\r\n                                    elit. In totam explicabo\r\n                                </div>\r\n                                <div class=\"notification-time\">\r\n                                    Yesterday\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n                    <div class=\"dropdown-divider\"></div>\r\n                    <a class=\"dropdown-item text-center\" href=\"#\">View all notifications</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"dropdown\">\r\n                <a href=\"#\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                    <i class=\"fa fa-envelope\"></i>\r\n                    <span class=\"badge badge-pill badge-success notification\">7</span>\r\n                </a>\r\n                <div class=\"dropdown-menu messages\" aria-labelledby=\"dropdownMenuMessage\">\r\n                    <div class=\"messages-header\">\r\n                        <i class=\"fa fa-envelope\"></i>\r\n                        Messages\r\n                    </div>\r\n                    <div class=\"dropdown-divider\"></div>\r\n                    <a class=\"dropdown-item\" href=\"#\">\r\n                        <div class=\"message-content\">\r\n                            <div class=\"pic\">\r\n                                <img src=\"/assets/img/user.jpg\" alt>\r\n                            </div>\r\n                            <div class=\"content\">\r\n                                <div class=\"message-title\">\r\n                                    <strong> Jhon doe</strong>\r\n                                </div>\r\n                                <div class=\"message-detail\">\r\n                                    Lorem ipsum dolor sit amet consectetur adipisicing\r\n                                    elit. In totam explicabo\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </a>\r\n                    <a class=\"dropdown-item\" href=\"#\">\r\n                        <div class=\"message-content\">\r\n                            <div class=\"pic\">\r\n                                <img src=\"/assets/img/user.jpg\" alt>\r\n                            </div>\r\n                            <div class=\"content\">\r\n                                <div class=\"message-title\">\r\n                                    <strong> Jhon doe</strong>\r\n                                </div>\r\n                                <div class=\"message-detail\">\r\n                                    Lorem ipsum dolor sit amet consectetur adipisicing\r\n                                    elit. In totam explicabo\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n                    </a>\r\n                    <a class=\"dropdown-item\" href=\"#\">\r\n                        <div class=\"message-content\">\r\n                            <div class=\"pic\">\r\n                                <img src=\"/assets/img/user.jpg\" alt>\r\n                            </div>\r\n                            <div class=\"content\">\r\n                                <div class=\"message-title\">\r\n                                    <strong> Jhon doe</strong>\r\n                                </div>\r\n                                <div class=\"message-detail\">\r\n                                    Lorem ipsum dolor sit amet consectetur adipisicing\r\n                                    elit. In totam explicabo\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </a>\r\n                    <div class=\"dropdown-divider\"></div>\r\n                    <a class=\"dropdown-item text-center\" href=\"#\">View all messages</a>\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"dropdown\">\r\n                <a href=\"#\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">\r\n                    <i class=\"fa fa-cog\"></i>\r\n                    <span class=\"badge-sonar\"></span>\r\n                </a>\r\n                <div class=\"dropdown-menu\" aria-labelledby=\"dropdownMenuMessage\">\r\n                    <a class=\"dropdown-item\" href=\"#\">My profile</a>\r\n                    <a class=\"dropdown-item\" href=\"#\">Help</a>\r\n                    <a class=\"dropdown-item\" href=\"#\">Setting</a>\r\n                </div>\r\n            </div>\r\n            <div>\r\n                <a href=\"#\">\r\n                    <i class=\"fa fa-power-off\"></i>\r\n                </a>\r\n            </div>\r\n            <div class=\"pinned-footer\">\r\n                <a href=\"#\">\r\n                    <i class=\"fas fa-ellipsis-h\"></i>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n    \r\n    ");
            __builder.OpenElement(4, "main");
            __builder.AddAttribute(5, "class", "page-content pt-2");
            __builder.AddMarkupContent(6, "\r\n        <div id=\"overlay\" class=\"overlay\"></div>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container-fluid p-5");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddContent(10, 
#nullable restore
#line 341 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\Shared\MainLayoutBusinessPartners - Copy.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 348 "C:\Users\samaritan\Documents\Visual Studio 2017\projects\sirach\LegatusHCM\BlazorClient\Client\Shared\MainLayoutBusinessPartners - Copy.razor"
 
    protected override async Task OnAfterRenderAsync(bool first_render)
    {
        if (first_render)
            await js.InvokeAsync<string>("init");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider authentication_state_provider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService local_storage { get; set; }
    }
}
#pragma warning restore 1591
