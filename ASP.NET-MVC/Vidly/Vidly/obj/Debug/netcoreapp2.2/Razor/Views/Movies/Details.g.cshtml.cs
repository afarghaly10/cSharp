#pragma checksum "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4de86181ae5e026a52e177f434cecd8759394363"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Details.cshtml", typeof(AspNetCore.Views_Movies_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#line 2 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de86181ae5e026a52e177f434cecd8759394363", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3385476d4b85d199b00cf2e726d5a33682ed59", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vidly.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Details.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(85, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(91, 10, false);
#line 8 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(101, 26, true);
            WriteLiteral("</h2>\n<ul>\n    <li>Genre: ");
            EndContext();
            BeginContext(128, 16, false);
#line 10 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Details.cshtml"
          Write(Model.Genre.Name);

#line default
#line hidden
            EndContext();
            BeginContext(144, 29, true);
            WriteLiteral("</li>\n    <li>Released Date: ");
            EndContext();
            BeginContext(174, 18, false);
#line 11 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Details.cshtml"
                  Write(Model.ReleasedDate);

#line default
#line hidden
            EndContext();
            BeginContext(192, 26, true);
            WriteLiteral("</li>\n    <li>Date Added: ");
            EndContext();
            BeginContext(219, 15, false);
#line 12 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Details.cshtml"
               Write(Model.DateAdded);

#line default
#line hidden
            EndContext();
            BeginContext(234, 31, true);
            WriteLiteral("</li>\n    <li>Number in Stock: ");
            EndContext();
            BeginContext(266, 19, false);
#line 13 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Details.cshtml"
                    Write(Model.NumberInStock);

#line default
#line hidden
            EndContext();
            BeginContext(285, 17, true);
            WriteLiteral("</li>\n    \n</ul>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vidly.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
