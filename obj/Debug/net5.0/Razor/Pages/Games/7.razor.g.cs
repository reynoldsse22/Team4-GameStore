#pragma checksum "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a50f3fae0ddaf8823507431a9661ea8df2c082c9"
// <auto-generated/>
#pragma warning disable 1591
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
#line 4 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Games/7")]
    public partial class _7 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 91 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
 foreach (var review in Reviews)
{
  if(review.GameID == 7)
    {
      NumOfReviewsForGame++;
      if(review.Stars == 1){
        num1Stars++;
      }else if(review.Stars == 2){
          num2Stars++;
      }else if(review.Stars == 3){
        num3Stars++;
      }else if(review.Stars == 4){
        num4Stars++;
      }else if(review.Stars == 5){
        num5Stars++;
      }
      Stars += review.Stars;
      NumberOfReviews++;
    }
    
    
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
 for (int i = 0; i < 1; i++)
{
    calculateStats();
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorApp.Shared.GameDetail>(0);
            __builder.AddAttribute(1, "Game", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Game>(
#nullable restore
#line 120 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
                  game

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "InCart", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 120 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
                                false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "InWishList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 120 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
                                                   false

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n<br>\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "review-border");
            __builder.AddMarkupContent(7, "<span class=\"heading\">User Rating</span>");
#nullable restore
#line 124 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
 for(int i = 1; i <= 5; i++)
{
    if(i <= Rating)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<span class=\"fa fa-star checked\"></span>");
#nullable restore
#line 129 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<span class=\"fa fa-star\"></span>");
#nullable restore
#line 133 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
    }
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "p");
            __builder.AddContent(11, 
#nullable restore
#line 135 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
    String.Format("{0:0.00}",Average)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, " average based on ");
            __builder.AddContent(13, 
#nullable restore
#line 135 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
                                                        NumberOfReviews

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " reviews.");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n<hr style=\"border:3px solid #f1f1f1\">\r\n\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "row");
            __builder.AddMarkupContent(18, "<div class=\"side\"><div style=\"padding-left:30px;\">5 star</div></div>\r\n  ");
            __builder.AddMarkupContent(19, "<div class=\"middle\"><div class=\"bar-container\"><div class=\"bar-5\"></div></div></div>\r\n  ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "side right");
            __builder.OpenElement(22, "div");
            __builder.AddContent(23, 
#nullable restore
#line 148 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
          num5Stars

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n  ");
            __builder.AddMarkupContent(25, "<div class=\"side\"><div style=\"padding-left:30px;\">4 star</div></div>\r\n  ");
            __builder.AddMarkupContent(26, "<div class=\"middle\"><div class=\"bar-container\"><div class=\"bar-4\"></div></div></div>\r\n  ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "side right");
            __builder.OpenElement(29, "div");
            __builder.AddContent(30, 
#nullable restore
#line 159 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
          num4Stars

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n  ");
            __builder.AddMarkupContent(32, "<div class=\"side\"><div style=\"padding-left:30px;\">3 star</div></div>\r\n  ");
            __builder.AddMarkupContent(33, "<div class=\"middle\"><div class=\"bar-container\"><div class=\"bar-3\"></div></div></div>\r\n  ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "side right");
            __builder.OpenElement(36, "div");
            __builder.AddContent(37, 
#nullable restore
#line 170 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
          num3Stars

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n  ");
            __builder.AddMarkupContent(39, "<div class=\"side\"><div style=\"padding-left:30px;\">2 star</div></div>\r\n  ");
            __builder.AddMarkupContent(40, "<div class=\"middle\"><div class=\"bar-container\"><div class=\"bar-2\"></div></div></div>\r\n  ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "side right");
            __builder.OpenElement(43, "div");
            __builder.AddContent(44, 
#nullable restore
#line 181 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
          num2Stars

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n  ");
            __builder.AddMarkupContent(46, "<div class=\"side\"><div style=\"padding-left:30px;\">1 star</div></div>\r\n  ");
            __builder.AddMarkupContent(47, "<div class=\"middle\"><div class=\"bar-container\"><div class=\"bar-1\"></div></div></div>\r\n  ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "side right");
            __builder.OpenElement(50, "div");
            __builder.AddContent(51, 
#nullable restore
#line 192 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
          num1Stars

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n<br>");
#nullable restore
#line 198 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
 if(@NumOfReviewsForGame < 1){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "<h3 style=\"text-align:left\">No Reviews Yet</h3>");
#nullable restore
#line 200 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
}
else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(54, "<h3 style=\"text-align:left\">Reviews</h3>");
#nullable restore
#line 203 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(55, "<hr style=\"border:1px solid #f1f1f1\">");
#nullable restore
#line 206 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
 foreach (var review in Reviews)
{
    if(review.GameID == 7)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorApp.Shared.ReviewDetail>(56);
            __builder.AddAttribute(57, "Review", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Review>(
#nullable restore
#line 210 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
                              review

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 211 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
    }
    
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorApp.Shared.ReviewSubmission>(58);
            __builder.AddAttribute(59, "NewReview", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Review>(
#nullable restore
#line 215 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
                             newReview

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "GameID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 215 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
                                                7

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(61, "\r\n\r\n");
            __builder.OpenElement(62, "style");
            __builder.AddMarkupContent(63, @"
  * {
  box-sizing: border-box;
}

.heading {
  font-size: 25px;
  margin-right: 25px;
}

.fa {
  font-size: 25px;
}

.checked {
  color: orange;
}

/* Three column layout */
.side {
  float: left;
  width: 15%;
  margin-top: 10px;
}

.middle {
  float: left;
  width: 70%;
  margin-top: 10px;
}

/* Place text to the right */
.right {
  text-align: right;
  padding-right: 30px;
}

/* Clear floats after the columns */
.row:after {
  content: """";
  display: table;
  clear: both;
}

/* The bar container */
.bar-container {
  width: 100%;
  background-color: #f1f1f1;
  text-align: center;
  color: white;
}

/* Individual bars */
.bar-5 {width: ");
            __builder.AddContent(64, 
#nullable restore
#line 270 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
                width5

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(65, "%; height: 18px; background-color: #04AA6D;}\r\n.bar-4 {width: ");
            __builder.AddContent(66, 
#nullable restore
#line 271 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
                width4

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(67, "%; height: 18px; background-color: #2196F3;}\r\n.bar-3 {width: ");
            __builder.AddContent(68, 
#nullable restore
#line 272 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
                width3

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(69, "%; height: 18px; background-color: #00bcd4;}\r\n.bar-2 {width: ");
            __builder.AddContent(70, 
#nullable restore
#line 273 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
                width2

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(71, "%; height: 18px; background-color: #ff9800;}\r\n.bar-1 {width: ");
            __builder.AddContent(72, 
#nullable restore
#line 274 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
                width1

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(73, "%; height: 18px; background-color: #f44336;}\r\n\r\n.review-border{\r\n  border:groove;\r\n  border-width: 5px;\r\n  border-radius: 5px;\r\n  padding: 25px;\r\n  border-color: #f1f1f1;\r\n}\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Games\7.razor"
 
    List<Game> Games = new List<Game>();
    
    List<Review> Reviews = new List<Review>();
    Game game = new Game();

    Review newReview = new Review();

    public int Stars{get;set;} = 0;
    public int Rating = 0;
    public float Average{get;set;} = 0;
    public float NumberOfReviews{get;set;} = 0;
    public int NumOfReviewsForGame{get;set;} = 0;
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
        game = Games.Where(x => x.ID == 7).FirstOrDefault();
    }

    private async Task RefreshReviews()
    {
        Reviews = await reviewService.GetReviews(); 
    }
    
    public void calculateStats() {
      if(NumOfReviewsForGame > 0)
      {

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
     else {
       Average = 0.0f;
       width1 = 0;
       width2 = 0;
       width3 = 0;
       width4 = 0;
       width5 = 0;
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
