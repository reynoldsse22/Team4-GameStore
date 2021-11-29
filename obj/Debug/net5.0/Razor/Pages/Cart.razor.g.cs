#pragma checksum "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ec11011f8c81c43030259498ea6184f8a6ff67f"
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
#line 4 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cart")]
    public partial class Cart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"text-align:center;\">Shopping Cart</h1>\n\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex flex-column");
#nullable restore
#line 38 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
     foreach (var game in Games)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorApp.Shared.GameDetail>(3);
            __builder.AddAttribute(4, "Game", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Game>(
#nullable restore
#line 40 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
                          game

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Quantity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 40 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
                                          game.Quantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "InCart", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
                                                                 true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 41 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
        Cost += (game.Price * game.Quantity);
        Tax = (Cost * 6.35f) / 100.0f;
        Total = Cost + Tax;
        CostString = String.Format("{0:0.00}",Cost);
        TaxString = String.Format("{0:0.00}",Tax);
        TotalString = String.Format("{0:0.00}",Total);
        CartQuantity += game.Quantity;
        
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
 if(CartQuantity > 0) 
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<br>\n    <hr size=\"25\" noshade>\n    ");
            __builder.OpenElement(8, "h4");
            __builder.AddContent(9, "Subtotal: $");
            __builder.AddContent(10, 
#nullable restore
#line 57 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
                    CostString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n    ");
            __builder.OpenElement(12, "h4");
            __builder.AddContent(13, "Tax:      $");
            __builder.AddContent(14, 
#nullable restore
#line 58 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
                    TaxString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n    <hr size=\"25\" noshade>\n    ");
            __builder.OpenElement(16, "h3");
            __builder.AddContent(17, "Total:    $");
            __builder.AddContent(18, 
#nullable restore
#line 60 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
                    TotalString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n    <br>\n    <br>\n    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-info");
            __builder.AddAttribute(22, "id", "CheckOutButton");
            __builder.AddAttribute(23, "name", "CheckOutButton");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
                                                                                     Checkout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Proceed To Checkout");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n    <br>\n    <br>\n    <br>\n    <br>");
#nullable restore
#line 68 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<h4 style=\"text-align:center; opacity:50%;\">Empty</h4>");
#nullable restore
#line 72 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\samre\OneDrive\Desktop\Team4-GameStore\Team4-GameStore\Pages\Cart.razor"
 
    List<Game> Games = new List<Game>();
    private float Cost = 0;
    private float Tax = 0;
    private float Total = 0;
    private string TaxString;
    private string TotalString;
    private string CostString;
    private int CartQuantity = 0;
    public string someString;

    private void Checkout() 
    {
        UriHelper.NavigateTo("/Checkout");
    }

    protected override async Task OnInitializedAsync()
    {
        await RefreshCart();
    }

    private async Task RefreshCart()
    {
        Games = await service.GetCart();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CartDbService service { get; set; }
    }
}
#pragma warning restore 1591
