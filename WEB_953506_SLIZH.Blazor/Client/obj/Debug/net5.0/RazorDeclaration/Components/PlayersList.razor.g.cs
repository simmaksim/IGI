// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WEB_953506_SLIZH.Blazor.Client.Components
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
    public partial class PlayersList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Dell\Desktop\IGI\WEB_953506_SLIZH.Blazor\Client\Components\PlayersList.razor"
       
    [Parameter]
    public IEnumerable<ListViewModel> Players { get; set; }
    [Parameter]
    public EventCallback<IEnumerable<ListViewModel>> PlayersChanged { get; set; }

    private int SelectedId = 0;
    [Parameter]
    public EventCallback<int> SelectedObjectChanged { get; set; }
    private void Selected(MouseEventArgs e, int id)
    {
        SelectedId = id;
        SelectedObjectChanged.InvokeAsync(id);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
