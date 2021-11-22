#pragma checksum "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\GameList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea2f8caea309f8562c6ce6bf1e020ddcdc06df7f"
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
#line 10 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\GameList.razor"
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
#line 17 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\GameList.razor"
 foreach (var game in Games)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorApp.Shared.GameDetail>(1);
            __builder.AddAttribute(2, "Game", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Game>(
#nullable restore
#line 19 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\GameList.razor"
                      game

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ShowBuyButton", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 19 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\GameList.razor"
                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 20 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\GameList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\GameList.razor"
 
    private List<Game> Games;

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
