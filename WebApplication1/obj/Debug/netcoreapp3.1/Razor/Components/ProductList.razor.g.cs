#pragma checksum "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b27ed72f65a74602ab68f1bcd60f79a68f630a"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-columns");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
 foreach(var product in ProductService.GetProducts()){

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-img");
            __builder.AddAttribute(9, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 9 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                                             product.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.AddMarkupContent(13, "\r\n\r\n    ");
            __builder.OpenElement(14, "h5");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, " ");
#nullable restore
#line 12 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
__builder.AddContent(17, product.Title);

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-footer");
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "small");
            __builder.AddAttribute(26, "class", "text-muted");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                  (e => SelectProduct(product.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "data-toggle", "modal");
            __builder.AddAttribute(31, "data-target", "#productModal");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddContent(33, "More Info");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 20 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n\r\n");
#nullable restore
#line 25 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
 if (selectProduct != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "modal fade");
            __builder.AddAttribute(41, "id", "productModal");
            __builder.AddAttribute(42, "tabindex", "-1");
            __builder.AddAttribute(43, "role", "dialog");
            __builder.AddAttribute(44, "aria-labelledby", "productTitle");
            __builder.AddAttribute(45, "aria-hidden", "true");
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(49, "role", "document");
            __builder.AddMarkupContent(50, "\r\n      ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "modal-content");
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "modal-header");
            __builder.AddMarkupContent(56, "\r\n          ");
            __builder.OpenElement(57, "h5");
            __builder.AddAttribute(58, "class", "modal-title");
            __builder.AddAttribute(59, "id", "productTitle");
#nullable restore
#line 31 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
__builder.AddContent(60, selectProduct.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n          ");
            __builder.AddMarkupContent(62, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n          </button>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "modal-body");
            __builder.AddMarkupContent(66, "\r\n          ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "card");
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "card-img");
            __builder.AddAttribute(72, "style", "background-image:" + " url(\'" + (
#nullable restore
#line 38 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                                                 selectProduct.Image

#line default
#line hidden
#nullable disable
            ) + "\');");
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "card-body");
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.OpenElement(78, "p");
            __builder.AddAttribute(79, "class", "card-text");
#nullable restore
#line 41 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
__builder.AddContent(80, selectProduct.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "modal-footer");
            __builder.AddMarkupContent(87, "\r\n");
#nullable restore
#line 46 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                     if (voteCount == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "                        ");
            __builder.AddMarkupContent(89, "<span>Be the first to vote!</span>\r\n");
#nullable restore
#line 49 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "                        ");
            __builder.OpenElement(91, "span");
#nullable restore
#line 52 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
__builder.AddContent(92, voteCount);

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, " ");
#nullable restore
#line 52 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
__builder.AddContent(94, voteLabel);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
#nullable restore
#line 53 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                     for(int i = 0; i < 6; i++)
                    {
                        var currentStar = i;
                        if (i <= currentRating)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(96, "                            ");
            __builder.OpenElement(97, "span");
            __builder.AddAttribute(98, "class", "fa-star checked");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                                                    (e=>SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n");
#nullable restore
#line 60 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "                            ");
            __builder.OpenElement(102, "span");
            __builder.AddAttribute(103, "class", "fa-star fa");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                                                               (e=>SubmitRating(currentStar))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
#nullable restore
#line 64 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(106, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n      ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n  ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n");
#nullable restore
#line 71 "C:\Users\sevval\source\repos\WebApplication1\WebApplication1\Components\ProductList.razor"
}

#line default
#line hidden
#nullable disable
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
