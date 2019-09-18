#pragma checksum "/Users/a.farghaly/Desktop/languages/C#/Labs/NETCoreMVC/Vidly/Vidly/Views/Movies/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71923719cb0349a3829f672f44c98c0ea6a65aa3"
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
#line 1 "/Users/a.farghaly/Desktop/languages/C#/Labs/NETCoreMVC/Vidly/Vidly/Views/_ViewImports.cshtml"
using Vidly;

#line default
#line hidden
#line 2 "/Users/a.farghaly/Desktop/languages/C#/Labs/NETCoreMVC/Vidly/Vidly/Views/_ViewImports.cshtml"
using Vidly.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71923719cb0349a3829f672f44c98c0ea6a65aa3", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3385476d4b85d199b00cf2e726d5a33682ed59", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vidly.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/a.farghaly/Desktop/languages/C#/Labs/NETCoreMVC/Vidly/Vidly/Views/Movies/Index.cshtml"
  
    ViewBag.Title = "Movies";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(121, 17, true);
            WriteLiteral("\n<h2>Movies</h2>\n");
            EndContext();
#line 9 "/Users/a.farghaly/Desktop/languages/C#/Labs/NETCoreMVC/Vidly/Vidly/Views/Movies/Index.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
            BeginContext(159, 44, true);
            WriteLiteral("    <p>We don\'t have any customers yet.</p>\n");
            EndContext();
#line 12 "/Users/a.farghaly/Desktop/languages/C#/Labs/NETCoreMVC/Vidly/Vidly/Views/Movies/Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(212, 199, true);
            WriteLiteral("    <table class=\"table table-bordered table-hover\">\n        <thead>\n            <tr>\n                <th>Movie</th>\n                <th>Genre</th>\n            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 23 "/Users/a.farghaly/Desktop/languages/C#/Labs/NETCoreMVC/Vidly/Vidly/Views/Movies/Index.cshtml"
             foreach (var movie in Model)
            {

#line default
#line hidden
            BeginContext(467, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(513, 77, false);
#line 26 "/Users/a.farghaly/Desktop/languages/C#/Labs/NETCoreMVC/Vidly/Vidly/Views/Movies/Index.cshtml"
                   Write(Html.ActionLink(movie.Name, "Details", "Movies", new { id = movie.Id }, null));

#line default
#line hidden
            EndContext();
            BeginContext(590, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(621, 16, false);
#line 27 "/Users/a.farghaly/Desktop/languages/C#/Labs/NETCoreMVC/Vidly/Vidly/Views/Movies/Index.cshtml"
                   Write(movie.Genre.Name);

#line default
#line hidden
            EndContext();
            BeginContext(637, 28, true);
            WriteLiteral("</td>\n                </tr>\n");
            EndContext();
#line 29 "/Users/a.farghaly/Desktop/languages/C#/Labs/NETCoreMVC/Vidly/Vidly/Views/Movies/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(679, 30, true);
            WriteLiteral("        </tbody>\n    </table>\n");
            EndContext();
#line 32 "/Users/a.farghaly/Desktop/languages/C#/Labs/NETCoreMVC/Vidly/Vidly/Views/Movies/Index.cshtml"
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
