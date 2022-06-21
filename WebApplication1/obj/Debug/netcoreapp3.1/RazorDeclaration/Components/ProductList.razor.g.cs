// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication1.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
using WebApplication1.Services;

#line default
#line hidden
#nullable disable
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
       
    Product selectProduct;
    string selectProductId;

    void SelectProduct(string productId)
    {
        selectProductId = productId;
        selectProduct = ProductService.GetProducts().First(x => x.Id == selectProductId);
        GetCurrentRating();
    }

    int currentRating=0;
    int voteCount = 0;
    string voteLabel;

    void GetCurrentRating()
    {
        if (selectProduct.Ratings == null)
        {
            currentRating = 0;
            voteCount = 0;
        }
        else
        {
            voteCount = selectProduct.Ratings.Count();
            voteLabel = voteCount > 1 ? "Votes" : "Vote";
            currentRating = selectProduct.Ratings.Sum() / voteCount;
        }

        System.Console.WriteLine($"Current rating for {selectProduct.Id}:{currentRating}");
    }

    void SubmitRating(int rating)
    {
        System.Console.WriteLine($"Rating recieved for{selectProduct.Id}:{rating}");
        ProductService.AddRating(selectProductId, rating);
        SelectProduct(selectProductId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private JsonFileProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
