#pragma checksum "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "288d3451ecda77d2ade801d999d596ed85d3cb77"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppWebAssembly.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\_Imports.razor"
using BlazorAppWebAssembly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\_Imports.razor"
using BlazorAppWebAssembly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\_Imports.razor"
using BlazorAppWebAssembly.Models;

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
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from a webapi.</p>\r\n\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-secondary mb-5");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\Pages\Products.razor"
                                                 GetProductsAsync

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "Hämta produkter");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.AddMarkupContent(7, "<div class=\"accordion\" id=\"accordionExample\"><div class=\"accordion-item\"><h2 class=\"accordion-header\" id=\"headingOne\"><button class=\"accordion-button\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseOne\" aria-expanded=\"true\" aria-controls=\"collapseOne\">\r\n                Accordion Item #1\r\n            </button></h2>\r\n        <div id=\"collapseOne\" class=\"accordion-collapse collapse show\" aria-labelledby=\"headingOne\" data-bs-parent=\"#accordionExample\"><div class=\"accordion-body\"><strong>This is the first item\'s accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It\'s also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.\r\n            </div></div></div>\r\n    <div class=\"accordion-item\"><h2 class=\"accordion-header\" id=\"headingTwo\"><button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseTwo\" aria-expanded=\"false\" aria-controls=\"collapseTwo\">\r\n                Accordion Item #2\r\n            </button></h2>\r\n        <div id=\"collapseTwo\" class=\"accordion-collapse collapse\" aria-labelledby=\"headingTwo\" data-bs-parent=\"#accordionExample\"><div class=\"accordion-body\"><strong>This is the second item\'s accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It\'s also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.\r\n            </div></div></div>\r\n    <div class=\"accordion-item\"><h2 class=\"accordion-header\" id=\"headingThree\"><button class=\"accordion-button collapsed\" type=\"button\" data-bs-toggle=\"collapse\" data-bs-target=\"#collapseThree\" aria-expanded=\"false\" aria-controls=\"collapseThree\">\r\n                Accordion Item #3\r\n            </button></h2>\r\n        <div id=\"collapseThree\" class=\"accordion-collapse collapse\" aria-labelledby=\"headingThree\" data-bs-parent=\"#accordionExample\"><div class=\"accordion-body\"><strong>This is the third item\'s accordion body.</strong> It is hidden by default, until the collapse plugin adds the appropriate classes that we use to style each element. These classes control the overall appearance, as well as the showing and hiding via CSS transitions. You can modify any of this with custom CSS or overriding our default variables. It\'s also worth noting that just about any HTML can go within the <code>.accordion-body</code>, though the transition does limit overflow.\r\n            </div></div></div></div>");
#nullable restore
#line 48 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\Pages\Products.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p>No products found.</p>");
#nullable restore
#line 51 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\Pages\Products.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "<thead><tr><th>Id</th>\r\n                <th>Product Name</th>\r\n                <th>Short Description</th>\r\n                <th>Price</th></tr></thead>\r\n        ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 64 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\Pages\Products.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 67 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\Pages\Products.razor"
                         product.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 68 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\Pages\Products.razor"
                         product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 69 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\Pages\Products.razor"
                         product.ShortDescription

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 70 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\Pages\Products.razor"
                         product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\Pages\Products.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\Pages\Products.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "D:\WIN20\win20-aspnetwebapi\lektion-2\BlazorAppWebAssembly\Pages\Products.razor"
       
    private Product[] products;

    private async Task GetProductsAsync()
    {
        products = await Http.GetFromJsonAsync<Product[]>("https://win20-recapapi.azurewebsites.net/api/products");
    }

    protected override async Task OnInitializedAsync()
    {
        //await GetProductsAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
