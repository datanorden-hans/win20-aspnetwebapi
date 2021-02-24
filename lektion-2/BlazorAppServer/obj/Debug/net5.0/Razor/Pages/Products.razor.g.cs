#pragma checksum "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0693c204583871a48977515553c28a0815313110"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Products</h1>\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 10 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Id</th>\r\n                <th>Product Name</th>\r\n                <th>Short Description</th>\r\n                <th>Price</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 26 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 29 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor"
                         product.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 30 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor"
                         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 31 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor"
                         product.ShortDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 32 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor"
                         product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppServer\Pages\Products.razor"
}

#line default
#line hidden
#nullable disable
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