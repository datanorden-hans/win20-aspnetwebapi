// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\_Imports.razor"
using BlazorAppServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\_Imports.razor"
using BlazorAppServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor"
using BlazorAppServer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor"
using BlazorAppServer.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor"
       
    private IEnumerable<ProductModel> products;

    protected override async Task OnInitializedAsync()
    {
        products = await ForecastService.GetProductsAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
