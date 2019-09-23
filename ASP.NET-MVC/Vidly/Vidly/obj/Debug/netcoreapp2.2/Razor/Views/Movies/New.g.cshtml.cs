#pragma checksum "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4339decb587e25ae15ceff8aa4ca4cdcdee1104f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_New), @"mvc.1.0.view", @"/Views/Movies/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movies/New.cshtml", typeof(AspNetCore.Views_Movies_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4339decb587e25ae15ceff8aa4ca4cdcdee1104f", @"/Views/Movies/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3385476d4b85d199b00cf2e726d5a33682ed59", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vidly.ViewModels.MovieViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(98, 50, true);
            WriteLiteral("\n<h2 style=\"margin-top: 10px\">New Movie</h2>\n<hr>\n");
            EndContext();
#line 10 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
 using (Html.BeginForm("Save", "Movies"))
{
    

#line default
#line hidden
            BeginContext(197, 24, false);
#line 12 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(222, 37, true);
            WriteLiteral("    <div class=\"form-group\">\n        ");
            EndContext();
            BeginContext(260, 32, false);
#line 14 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
   Write(Html.LabelFor(n => n.Movie.Name));

#line default
#line hidden
            EndContext();
            BeginContext(292, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(302, 65, false);
#line 15 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
   Write(Html.TextBoxFor( n=> n.Movie.Name, new {@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(367, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(377, 44, false);
#line 16 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
   Write(Html.ValidationMessageFor(m => m.Movie.Name));

#line default
#line hidden
            EndContext();
            BeginContext(421, 51, true);
            WriteLiteral("\n    </div>\n     <div class=\"form-group\">\n         ");
            EndContext();
            BeginContext(473, 40, false);
#line 19 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
    Write(Html.LabelFor(n => n.Movie.ReleasedDate));

#line default
#line hidden
            EndContext();
            BeginContext(513, 10, true);
            WriteLiteral("\n         ");
            EndContext();
            BeginContext(524, 91, false);
#line 20 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
    Write(Html.TextBoxFor( n=> n.Movie.ReleasedDate, "{0:d MMM yyyy}", new {@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(615, 10, true);
            WriteLiteral("\n         ");
            EndContext();
            BeginContext(626, 52, false);
#line 21 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
    Write(Html.ValidationMessageFor(m => m.Movie.ReleasedDate));

#line default
#line hidden
            EndContext();
            BeginContext(678, 50, true);
            WriteLiteral("\n     </div>\n    <div class=\"form-group\">\n        ");
            EndContext();
            BeginContext(729, 33, false);
#line 24 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
   Write(Html.LabelFor(n => n.Movie.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(762, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(772, 119, false);
#line 25 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
   Write(Html.DropDownListFor( n=> n.Movie.GenreId, new SelectList(Model.Genres, "Id", "Name"),"",new {@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(891, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(901, 45, false);
#line 26 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
   Write(Html.ValidationMessageFor(m => m.Movie.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(946, 49, true);
            WriteLiteral("\n    </div>\n    <div class=\"form-group\">\n        ");
            EndContext();
            BeginContext(996, 41, false);
#line 29 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
   Write(Html.LabelFor(n => n.Movie.NumberInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(1047, 74, false);
#line 30 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
   Write(Html.TextBoxFor( n=> n.Movie.NumberInStock, new {@class = "form-control"}));

#line default
#line hidden
            EndContext();
            BeginContext(1121, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(1131, 53, false);
#line 31 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
   Write(Html.ValidationMessageFor(m => m.Movie.NumberInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(1201, 31, false);
#line 33 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
Write(Html.HiddenFor(m => m.Movie.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 23, false);
#line 34 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1262, 65, true);
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Save</button> \n");
            EndContext();
#line 36 "/Users/a.farghaly/Desktop/GitHub/cSharp/ASP.NET-MVC/Vidly/Vidly/Views/Movies/New.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vidly.ViewModels.MovieViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
