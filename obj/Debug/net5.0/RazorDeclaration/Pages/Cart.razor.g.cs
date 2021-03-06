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
