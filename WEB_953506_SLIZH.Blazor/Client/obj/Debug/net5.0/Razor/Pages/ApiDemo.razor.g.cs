#pragma checksum "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\Pages\ApiDemo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be0845f1bfe838d75d2bfbdd1220120ea48bc162"
// <auto-generated/>
#pragma warning disable 1591
namespace WEB_953506_SLIZH.Blazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\_Imports.razor"
using WEB_953506_SLIZH.Blazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\_Imports.razor"
using WEB_953506_SLIZH.Blazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\_Imports.razor"
using WEB_953506_SLIZH.Blazor.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\Pages\ApiDemo.razor"
using WEB_953506_SLIZH.Blazor.Client.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/apidemo")]
    public partial class ApiDemo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenComponent<WEB_953506_SLIZH.Blazor.Client.Components.PlayersList>(2);
            __builder.AddAttribute(3, "SelectedObjectChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 6 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\Pages\ApiDemo.razor"
                                                                     ShowDetails

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "Players", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<WEB_953506_SLIZH.Blazor.Client.Models.ListViewModel>>(
#nullable restore
#line 6 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\Pages\ApiDemo.razor"
                                     Players

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "PlayersChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Collections.Generic.IEnumerable<WEB_953506_SLIZH.Blazor.Client.Models.ListViewModel>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Collections.Generic.IEnumerable<WEB_953506_SLIZH.Blazor.Client.Models.ListViewModel>>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Players = __value, Players))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<WEB_953506_SLIZH.Blazor.Client.Components.PlayerDetail>(7);
            __builder.AddAttribute(8, "Player", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WEB_953506_SLIZH.Blazor.Client.Models.DetailViewModel>(
#nullable restore
#line 7 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\Pages\ApiDemo.razor"
                                    SelectedPlayer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "PlayerChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<WEB_953506_SLIZH.Blazor.Client.Models.DetailViewModel>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<WEB_953506_SLIZH.Blazor.Client.Models.DetailViewModel>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedPlayer = __value, SelectedPlayer))));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\Pages\ApiDemo.razor"
           
        [Parameter]
        public IEnumerable<ListViewModel> Players { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Players = await client.GetFromJsonAsync<IEnumerable<ListViewModel>>("api/players");
        }
        [Parameter]
        public DetailViewModel SelectedPlayer { get; set; }
        private async Task ShowDetails(int id)
        {
            SelectedPlayer = await client.GetFromJsonAsync<DetailViewModel>($"api/players/{id}");
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591