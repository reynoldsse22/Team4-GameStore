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
#line 4 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\2.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Games/2")]
    public partial class _2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\2.razor"
 
    List<Game> Games = new List<Game>();
    
    List<Review> Reviews = new List<Review>();
    Game game = new Game();

    Review newReview = new Review();

    public int Stars{get;set;} = 0;
    public int Rating = 0;
    public float Average{get;set;} = 0;
    public float NumberOfReviews{get;set;} = 0;
    public float num1Stars{get;set;} = 0;
    public float num2Stars{get;set;} = 0;
    public float num3Stars{get;set;} = 0;
    public float num4Stars{get;set;} = 0;
    public float num5Stars{get;set;} = 0;
    public float width1{get;set;}
    public float width2{get;set;}
    public float width3{get;set;}
    public float width4{get;set;}
    public float width5{get;set;}
    protected override async Task OnInitializedAsync()
    {
        await RefreshGames();
        await RefreshReviews();
    }

    private async Task RefreshGames()
    {
        Games = await service.GetGames(); 
        game = Games.Where(x => x.ID == 2).FirstOrDefault();
    }

    private async Task RefreshReviews()
    {
        Reviews = await reviewService.GetReviews(); 
    }
    
    public void calculateStats() {
        width1 = ((num1Stars/NumberOfReviews)*100.0f);
        width2 = ((num2Stars/NumberOfReviews)*100.0f);
        width3 = ((num3Stars/NumberOfReviews)*100.0f);
        width4 = ((num4Stars/NumberOfReviews)*100.0f);
        width5 = ((num5Stars/NumberOfReviews)*100.0f);
        Average = (((num5Stars*5) + (num4Stars*4) + (num3Stars*3) + (num2Stars*2)+(num1Stars*1) )/ NumberOfReviews);

        if (Average > 1){
            if (Average > 2){
                if (Average > 3){
                    if (Average > 4){
                        Rating=5;
                    }
                    else{
                        Rating=4;
                    }
                }
                else{
                    Rating=3;
                }
            }
            else{
                Rating=2;
            }
        }
        else{
            Rating=1;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ReviewDbService reviewService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GameDbService service { get; set; }
    }
}
#pragma warning restore 1591
