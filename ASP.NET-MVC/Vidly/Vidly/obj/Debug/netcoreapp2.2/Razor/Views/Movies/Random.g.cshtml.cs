#pragma checksum "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Random.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9911960165c364c494cd5d1fa2aaf5612c18b55f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Random), @"mvc.1.0.view", @"/Views/Movies/Random.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Random.cshtml", typeof(AspNetCore.Views_Movies_Random))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9911960165c364c494cd5d1fa2aaf5612c18b55f", @"/Views/Movies/Random.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3385476d4b85d199b00cf2e726d5a33682ed59", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Random : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vidly.ViewModels.RandomMovieViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Random.cshtml"
  
    ViewBag.Title = "Random";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(105, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(161, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 12 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Random.cshtml"
  
    var className = Model.Customers.Count > 0 ? "popular" : null;

#line default
#line hidden
            BeginContext(233, 4, true);
            WriteLiteral("\n<h2");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 237, "\"", 255, 1);
#line 16 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Random.cshtml"
WriteAttributeValue("", 245, className, 245, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(256, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(258, 16, false);
#line 16 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Random.cshtml"
                  Write(Model.Movie.Name);

#line default
#line hidden
            EndContext();
            BeginContext(274, 7, true);
            WriteLiteral("</h2>\n\n");
            EndContext();
#line 18 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Random.cshtml"
 if (Model.Customers.Count == 0)
{

#line default
#line hidden
            BeginContext(316, 48, true);
            WriteLiteral("    <p> No one has rented this movie before</p>\n");
            EndContext();
#line 21 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Random.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(373, 9, true);
            WriteLiteral("    <ul>\n");
            EndContext();
#line 25 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Random.cshtml"
         foreach (var customer in Model.Customers)
        {

#line default
#line hidden
            BeginContext(443, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(460, 13, false);
#line 27 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Random.cshtml"
           Write(customer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(473, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 28 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Random.cshtml"
        }

#line default
#line hidden
            BeginContext(489, 10, true);
            WriteLiteral("    </ul>\n");
            EndContext();
#line 30 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Random.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vidly.ViewModels.RandomMovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
