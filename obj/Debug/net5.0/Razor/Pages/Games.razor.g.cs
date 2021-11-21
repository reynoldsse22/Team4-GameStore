#pragma checksum "C:\Users\cocar\Downloads\Team4-Project2-main\Pages\Games.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cdd88707e9d6da6a87c347dad955f101cba319d"
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
#line 1 "C:\Users\cocar\Downloads\Team4-Project2-main\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cocar\Downloads\Team4-Project2-main\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cocar\Downloads\Team4-Project2-main\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cocar\Downloads\Team4-Project2-main\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cocar\Downloads\Team4-Project2-main\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cocar\Downloads\Team4-Project2-main\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cocar\Downloads\Team4-Project2-main\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cocar\Downloads\Team4-Project2-main\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cocar\Downloads\Team4-Project2-main\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cocar\Downloads\Team4-Project2-main\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/games")]
    public partial class Games : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Games</h3>\r\n\r\n");
            __builder.OpenElement(1, "u1");
#nullable restore
#line 6 "C:\Users\cocar\Downloads\Team4-Project2-main\Pages\Games.razor"
     foreach(var game in gaming)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "li");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "checkbox");
            __builder.AddAttribute(5, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\cocar\Downloads\Team4-Project2-main\Pages\Games.razor"
                                          game.gameIsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => game.gameIsDone = __value, game.gameIsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n            ");
#nullable restore
#line 10 "C:\Users\cocar\Downloads\Team4-Project2-main\Pages\Games.razor"
__builder.AddContent(8, game.gameName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "img");
            __builder.AddAttribute(11, "src", 
#nullable restore
#line 12 "C:\Users\cocar\Downloads\Team4-Project2-main\Pages\Games.razor"
                  game.gameLink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "asp-append-version", "true");
            __builder.AddAttribute(13, "width", "300px");
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\cocar\Downloads\Team4-Project2-main\Pages\Games.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<br> \r\n    ");
            __builder.AddMarkupContent(15, "<p><label>Currently In Cart</label></p>");
#nullable restore
#line 19 "C:\Users\cocar\Downloads\Team4-Project2-main\Pages\Games.razor"
     foreach (var c in cart)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "li");
#nullable restore
#line 21 "C:\Users\cocar\Downloads\Team4-Project2-main\Pages\Games.razor"
__builder.AddContent(17, c.gameName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\cocar\Downloads\Team4-Project2-main\Pages\Games.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "p");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\cocar\Downloads\Team4-Project2-main\Pages\Games.razor"
                          AddCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Add To Cart");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenComponent<BlazorApp.Pages.Cart>(23);
            __builder.AddAttribute(24, "gameCart", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<GameList>>(
#nullable restore
#line 26 "C:\Users\cocar\Downloads\Team4-Project2-main\Pages\Games.razor"
                     cart

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\cocar\Downloads\Team4-Project2-main\Pages\Games.razor"
       
    private string deez;
    private List<GameList> cart = new();
    private List<GameList> gaming = new() { new GameList{ gameName = "Rockman", gameLink = "Images/deeznutssss.webp"},
                                            new GameList{gameName = "Mario Pratt", gameLink = "Images/Mario.jpg"},
                                            new GameList{gameName = "Skyrim 90th edition", gameLink = "Images/skyrim.png"} };

    private void AddCart()
    {
        foreach(var g in gaming)
        {
            if(g.gameIsDone && !cart.Contains(g))
            {
                cart.Add(g);
            }
            else if(!g.gameIsDone && cart.Contains(g))
            {
                cart.Remove(g);
            }
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
