// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "d:\WIN20\win20-aspnetwebapi\lektion-4\repetition\WebApiWithKey\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\WIN20\win20-aspnetwebapi\lektion-4\repetition\WebApiWithKey\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "d:\WIN20\win20-aspnetwebapi\lektion-4\repetition\WebApiWithKey\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "d:\WIN20\win20-aspnetwebapi\lektion-4\repetition\WebApiWithKey\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "d:\WIN20\win20-aspnetwebapi\lektion-4\repetition\WebApiWithKey\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "d:\WIN20\win20-aspnetwebapi\lektion-4\repetition\WebApiWithKey\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "d:\WIN20\win20-aspnetwebapi\lektion-4\repetition\WebApiWithKey\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "d:\WIN20\win20-aspnetwebapi\lektion-4\repetition\WebApiWithKey\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "d:\WIN20\win20-aspnetwebapi\lektion-4\repetition\WebApiWithKey\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "d:\WIN20\win20-aspnetwebapi\lektion-4\repetition\WebApiWithKey\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "d:\WIN20\win20-aspnetwebapi\lektion-4\repetition\WebApiWithKey\BlazorApp\_Imports.razor"
using SharedLibrary.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "d:\WIN20\win20-aspnetwebapi\lektion-4\repetition\WebApiWithKey\BlazorApp\Pages\Index.razor"
       
    private IEnumerable<Product> products;

    protected override async Task OnInitializedAsync()
    {
        products = await Http.GetFromJsonAsync<IEnumerable<Product>>("https://localhost:44367/api/products?AccessKey=34332f77932e4486975d9b937b77d18e==");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
