#pragma checksum "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ec47e8752e0a025d6c5dab5d53e1929e17f084f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Login</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\Pages\Login.razor"
                 model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\Pages\Login.razor"
                                  OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(5);
                __builder2.AddAttribute(6, "type", "text");
                __builder2.AddAttribute(7, "id", "email");
                __builder2.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\Pages\Login.razor"
                                                   model.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Email = __value, model.Email))));
                __builder2.AddAttribute(10, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "type", "password");
                __builder2.AddAttribute(14, "id", "password");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\Pages\Login.razor"
                                                          model.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Password = __value, model.Password))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.AddMarkupContent(19, "<button class=\"btn btn-success\" type=\"submit\">Sign In</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "D:\WIN20\win20-aspnetwebapi\lektion-7\SimpleAuthExample\BlazorApp\Pages\Login.razor"
       
    private LoginModel model { get; set; }

    protected override void OnInitialized()
    {
        model = new LoginModel();
    }

    private async Task OnSubmit()
    {
        var response = await Http.PostAsJsonAsync<LoginModel>("https://localhost:44380/api/Authentication/signin", model);
        await sessionStorage.SetItemAsync<string>("auth", await response.Content.ReadAsStringAsync());
        NavManager.NavigateTo("/");
    }


    public class LoginModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591