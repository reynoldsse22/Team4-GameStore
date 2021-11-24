// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages.Games
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
#line 4 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\4.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Games/4")]
    public partial class _4 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\4.razor"
 
    List<Game> Games = new List<Game>();
    
    List<Review> Reviews = new List<Review>();
    Game game = new Game();
    protected override async Task OnInitializedAsync()
    {
        await RefreshGames();
        await RefreshReviews();
    }

    private async Task RefreshGames()
    {
        Games = await service.GetGames(); 
        game = Games.Where(x => x.ID == 4).FirstOrDefault();
    }

    private async Task RefreshReviews()
    {
        Reviews = await reviewService.GetReviews(); 
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ReviewDbService reviewService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GameDbService service { get; set; }
    }
}
#pragma warning restore 1591
