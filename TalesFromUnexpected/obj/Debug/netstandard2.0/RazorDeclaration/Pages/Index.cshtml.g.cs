#pragma checksum "C:\Users\damia\source\repos\TalesFromUnexpected\TalesFromUnexpected\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bc5713eeeb1dac087fade9d9c04d6f2f5957537"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
