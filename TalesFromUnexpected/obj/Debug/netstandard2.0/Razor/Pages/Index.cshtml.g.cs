#pragma checksum "C:\Users\damia\source\repos\TalesFromUnexpected\TalesFromUnexpected\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bc5713eeeb1dac087fade9d9c04d6f2f5957537"
// <auto-generated/>
#pragma warning disable 1591
namespace TalesFromUnexpected.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using TalesFromUnexpected;
    using TalesFromUnexpected.Shared;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<div class=\"grid-center\">\r\n\r\n</div>\r\n\r\n");
            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "grid-btn");
            builder.AddContent(3, "\r\n    ");
            builder.OpenElement(4, "button");
            builder.AddAttribute(5, "type", "button");
            builder.AddAttribute(6, "class", "btn btn-link btn-lg fixed-button");
            builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, GetJokeAsync));
            builder.AddContent(8, "\r\n        ");
            builder.OpenElement(9, "img");
            builder.AddAttribute(10, "id", "chuck");
            builder.AddAttribute(11, "class", "center" + " glow" + " " + ((_isLoading ? "shaking" : "")));
            builder.AddAttribute(12, "alt", "Chuck Norris");
            builder.AddAttribute(13, "src", "https://i.imgur.com/NiSr76R.png");
            builder.AddAttribute(14, "width", "900");
            builder.CloseElement();
            builder.AddContent(15, "\r\n    ");
            builder.CloseElement();
            builder.AddContent(16, "\r\n");
            builder.CloseElement();
            builder.AddContent(17, "\r\n\r\n");
            builder.OpenElement(18, "div");
            builder.AddAttribute(19, "class", "grid-joke");
            builder.AddContent(20, "\r\n    ");
            builder.OpenElement(21, "div");
            builder.AddAttribute(22, "class", "alert alert-danger");
            builder.AddAttribute(23, "role", "alert");
            builder.AddContent(24, "\r\n");
#line 22 "C:\Users\damia\source\repos\TalesFromUnexpected\TalesFromUnexpected\Pages\Index.cshtml"
         if (_isLoading)
        {

#line default
#line hidden
            builder.AddContent(25, "            ");
            builder.AddMarkupContent(26, "<h1 class=\"hg-font\">...</h1>\r\n");
#line 25 "C:\Users\damia\source\repos\TalesFromUnexpected\TalesFromUnexpected\Pages\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            builder.AddContent(27, "            ");
            builder.OpenElement(28, "h1");
            builder.AddAttribute(29, "class", "hg-font");
            builder.AddContent(30, _rhyssQuote);
            builder.CloseElement();
            builder.AddContent(31, "\r\n");
#line 29 "C:\Users\damia\source\repos\TalesFromUnexpected\TalesFromUnexpected\Pages\Index.cshtml"
        }

#line default
#line hidden
            builder.AddContent(32, "    ");
            builder.CloseElement();
            builder.AddContent(33, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 34 "C:\Users\damia\source\repos\TalesFromUnexpected\TalesFromUnexpected\Pages\Index.cshtml"
            
    bool _isLoading = false;
    string _disabled => _isLoading ? "disabled" : null;
    string[] rhysQuotes;

    protected override async Task OnInitAsync()
    {
        rhysQuotes = Quotes.RhysQuotes;
        await Task.Delay(200);
    }

    string _rhyssQuote = "Click on Welsh Wizard to get little fact about him";

    private async Task GetJokeAsync()
    {
        _isLoading = true;

        _rhyssQuote = rhysQuotes.ToList().PickRandom();

        await Task.Delay(200);

        _isLoading = false;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
