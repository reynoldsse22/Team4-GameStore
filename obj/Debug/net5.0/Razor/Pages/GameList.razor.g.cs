#pragma checksum "C:\Users\cocar\Documents\GitHub\Team4-GameStore\Pages\GameList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8002508a1efaa23bb67ef99e0149a014e776bb2"
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
#line 1 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\Pages\GameList.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/games")]
    public partial class GameList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Used Games</h2>");
#nullable restore
#line 17 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\Pages\GameList.razor"
 foreach (KeyValuePair<Game, int> game in Games)
{
    

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorApp.Shared.GameDetail>(1);
            __builder.AddAttribute(2, "Game", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Game>(
#nullable restore
#line 20 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\Pages\GameList.razor"
                      game.Key

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Quantity", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 20 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\Pages\GameList.razor"
                                          game.Value

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "InCart", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\Pages\GameList.razor"
                                                              false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "InWishList", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\Pages\GameList.razor"
                                                                                 false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 21 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\Pages\GameList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\cocar\Documents\GitHub\Team4-GameStore\Pages\GameList.razor"
 
    public IDictionary<Game, int> Games;

    protected override void OnInitialized()
    {
        Games = GameService.GetAllGames();      
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GameService GameService { get; set; }
    }
}
#pragma warning restore 1591
