#pragma checksum "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b882a989f6b0eb9c142a8864d2981107ae6d5a47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.SnapShots_IndexFormGenreNoRating), @"mvc.1.0.razor-page", @"/SnapShots/IndexFormGenreNoRating.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b882a989f6b0eb9c142a8864d2981107ae6d5a47", @"/SnapShots/IndexFormGenreNoRating.cshtml")]
    public class SnapShots_IndexFormGenreNoRating : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<p>\n    <a asp-page=\"Create\">Create New</a>\n</p>\n\n<form>\n    <p>\n        <select asp-for=\"MovieGenre\" asp-items=\"Model.Genres\">\n            <option");
            BeginWriteAttribute("value", " value=\"", 256, "\"", 264, 0);
            EndWriteAttribute();
            WriteLiteral(">All</option>\n        </select>\n        Title: <input type=\"text\" asp-for=\"SearchString\" />\n        <input type=\"submit\" value=\"Filter\" />\n    </p>\n</form>\n\n<table class=\"table\">\n");
            WriteLiteral("\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 30 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 33 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 36 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 39 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 45 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
         foreach (var item in Model.Movie)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 49 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 52 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
               Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 55 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
               Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 58 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    <a asp-page=\"./Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1542, "\"", 1565, 1);
#nullable restore
#line 61 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
WriteAttributeValue("", 1557, item.ID, 1557, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\n                    <a asp-page=\"./Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1621, "\"", 1644, 1);
#nullable restore
#line 62 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
WriteAttributeValue("", 1636, item.ID, 1636, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\n                    <a asp-page=\"./Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1702, "\"", 1725, 1);
#nullable restore
#line 63 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
WriteAttributeValue("", 1717, item.ID, 1717, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n                </td>\n            </tr>\n");
#nullable restore
#line 66 "D:\Facultate\Anul3\TSP .Net\Facultate\Lab11_Mi16\RazorPagesMovie\RazorPagesMovie\SnapShots\IndexFormGenreNoRating.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
