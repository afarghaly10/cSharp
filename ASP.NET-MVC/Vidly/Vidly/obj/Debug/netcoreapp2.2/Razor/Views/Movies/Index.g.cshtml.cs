#pragma checksum "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aba3c598e94b67ba47da0fa8cb71a00235b748b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/Index.cshtml", typeof(AspNetCore.Views_Movies_Index))]
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
#line 1 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Index.cshtml"
using Vidly.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aba3c598e94b67ba47da0fa8cb71a00235b748b", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3385476d4b85d199b00cf2e726d5a33682ed59", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vidly.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Index.cshtml"
  
    ViewBag.Title = "Movies";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 92, true);
            WriteLiteral("\n<h2 style=\"margin-top: 10px\">Movies</h2>\n<hr>\n<button type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 237, "\"", 291, 3);
            WriteAttributeValue("", 247, "location.href=\'", 247, 15, true);
#line 11 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Index.cshtml"
WriteAttributeValue("", 262, Url.Action("New", "Movies"), 262, 28, false);

#line default
#line hidden
            WriteAttributeValue("", 290, "\'", 290, 1, true);
            EndWriteAttribute();
            BeginContext(292, 20, true);
            WriteLiteral(">New Movie</button>\n");
            EndContext();
#line 12 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Index.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
            BeginContext(333, 44, true);
            WriteLiteral("    <p>We don\'t have any customers yet.</p>\n");
            EndContext();
#line 15 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(386, 224, true);
            WriteLiteral("    <table class=\"table table-bordered table-hover\" style=\"margin-top: 10px\">\n        <thead>\n            <tr>\n                <th>Movie</th>\n                <th>Genre</th>\n            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 26 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Index.cshtml"
             foreach (var movie in Model)
            {

#line default
#line hidden
            BeginContext(666, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(712, 74, false);
#line 29 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Index.cshtml"
                   Write(Html.ActionLink(movie.Name, "Edit", "Movies", new { id = movie.Id }, null));

#line default
#line hidden
            EndContext();
            BeginContext(786, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(817, 16, false);
#line 30 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Index.cshtml"
                   Write(movie.Genre.Name);

#line default
#line hidden
            EndContext();
            BeginContext(833, 28, true);
            WriteLiteral("</td>\n                </tr>\n");
            EndContext();
#line 32 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(875, 30, true);
            WriteLiteral("        </tbody>\n    </table>\n");
            EndContext();
#line 35 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vidly.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
