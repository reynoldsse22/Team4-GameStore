#pragma checksum "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Shared\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63093aede458f13d39356494f5dfa06b1fb72d9e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Shared\Login.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Shared\Login.razor"
                  users

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Shared\Login.razor"
                                         ValidateUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "center");
                __builder2.AddAttribute(5, "b-jwlzop8dzi");
                __builder2.AddMarkupContent(6, "<div b-jwlzop8dzi><br b-jwlzop8dzi> <br b-jwlzop8dzi> <br b-jwlzop8dzi></div>\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "border col-5");
                __builder2.AddAttribute(9, "b-jwlzop8dzi");
                __builder2.AddMarkupContent(10, "<div class=\"col-12\" b-jwlzop8dzi><h3 style=\"color=Red; font-weight: bold\" b-jwlzop8dzi>ETSUsed Games</h3></div>\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "b-jwlzop8dzi");
                __builder2.AddMarkupContent(13, "<br b-jwlzop8dzi>\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "red");
                __builder2.AddAttribute(16, "b-jwlzop8dzi");
                __builder2.AddContent(17, 
#nullable restore
#line 21 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Shared\Login.razor"
                                   list

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                <br b-jwlzop8dzi>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-10");
                __builder2.AddAttribute(22, "b-jwlzop8dzi");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "class", "form-control inputs");
                __builder2.AddAttribute(25, "placeholder", "Email Address");
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Shared\Login.razor"
                                                           users.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => users.Email = __value, users.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(28, "b-jwlzop8dzi");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.AddMarkupContent(30, "<div b-jwlzop8dzi><br b-jwlzop8dzi></div>\r\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-10");
                __builder2.AddAttribute(33, "b-jwlzop8dzi");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "password");
                __builder2.AddAttribute(36, "class", "form-control inputs");
                __builder2.AddAttribute(37, "placeholder", "Password");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Shared\Login.razor"
                                                                           users.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => users.Password = __value, users.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(40, "b-jwlzop8dzi");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n            <br b-jwlzop8dzi>\r\n            ");
                __builder2.AddMarkupContent(42, "<div class=\"col-5\" b-jwlzop8dzi><input type=\"submit\" class=\"form-control btn btn-primary\" value=\"Login\" b-jwlzop8dzi></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Shared\Login.razor"
       

    
    private User users;
    private string list;

    private string email;

    private string password;
    protected override Task OnInitializedAsync()
    {
        users = new User();
        return base.OnInitializedAsync();
    }
    private async Task<bool> ValidateUser()
    {
        User UserAttempt;
        UserAttempt = await UserDbService.GetUser(users.Email, users.Password);
        if(UserAttempt != null)
        {
            ((CustomAuthProvider)AuthenticationStateProvider).MakeUserAuth(UserAttempt.FirstName);
            NavigationManager.NavigateTo("/games");
            await sessionStorage.SetItemAsync("email", UserAttempt.FirstName);
        }
        else
        {
            list = "Wrong Username or Password";
        }

        return await Task.FromResult(true);
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserDbService UserDbService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
