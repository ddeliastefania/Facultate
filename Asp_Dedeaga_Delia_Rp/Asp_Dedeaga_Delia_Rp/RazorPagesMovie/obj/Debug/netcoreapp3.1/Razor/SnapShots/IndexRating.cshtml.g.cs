#pragma checksum "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de2d22f1607a32eea04ce149de72e3186c98e7fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.SnapShots_IndexRating), @"mvc.1.0.razor-page", @"/SnapShots/IndexRating.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de2d22f1607a32eea04ce149de72e3186c98e7fd", @"/SnapShots/IndexRating.cshtml")]
    public class SnapShots_IndexRating : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    <a asp-page=\"Create\">Create New</a>\n</p>\n\n<form>\n    <p>\n        <select asp-for=\"MovieGenre\" asp-items=\"Model.Genres\">\n            <option");
            BeginWriteAttribute("value", " value=\"", 256, "\"", 264, 0);
            EndWriteAttribute();
            WriteLiteral(">All</option>\n        </select>\n        Title: <input type=\"text\" asp-for=\"SearchString\" />\n        <input type=\"submit\" value=\"Filter\" />\n    </p>\n</form>\n\n<table class=\"table\">\n\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 29 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 32 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 35 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 38 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 41 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 47 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
         foreach (var item in Model.Movie)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 51 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 54 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 57 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 60 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 63 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
               Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    <a asp-page=\"./Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1716, "\"", 1739, 1);
#nullable restore
#line 66 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
WriteAttributeValue("", 1731, item.ID, 1731, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\n                    <a asp-page=\"./Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1795, "\"", 1818, 1);
#nullable restore
#line 67 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
WriteAttributeValue("", 1810, item.ID, 1810, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\n                    <a asp-page=\"./Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1876, "\"", 1899, 1);
#nullable restore
#line 68 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
WriteAttributeValue("", 1891, item.ID, 1891, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n                </td>\n            </tr>\n");
#nullable restore
#line 71 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexRating.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Pages.Movies.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.Movies.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.Movies.IndexModel>)PageContext?.ViewData;
        public RazorPagesMovie.Pages.Movies.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
