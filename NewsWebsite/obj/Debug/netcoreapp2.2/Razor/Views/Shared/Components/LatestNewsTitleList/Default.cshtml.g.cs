#pragma checksum "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\Components\LatestNewsTitleList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c922ee2fd01c0ea8964fa4e0d869622f61b0472"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LatestNewsTitleList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LatestNewsTitleList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/LatestNewsTitleList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_LatestNewsTitleList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c922ee2fd01c0ea8964fa4e0d869622f61b0472", @"/Views/Shared/Components/LatestNewsTitleList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LatestNewsTitleList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsWebsite.ViewModels.News.NewsViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 230, true);
            WriteLiteral("\r\n    <div class=\"breaking-news-area d-flex align-items-center\">\r\n        <div class=\"news-title\">\r\n            <p>تیتر جدیدترین اخبار :</p>\r\n        </div>\r\n        <div id=\"breakingNewsTicker\" class=\"ticker\">\r\n            <ul>\r\n");
            EndContext();
#line 9 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\Components\LatestNewsTitleList\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(352, 26, true);
            WriteLiteral("                    <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 378, "\"", 408, 4);
            WriteAttributeValue("", 385, "/", 385, 1, true);
#line 11 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\Components\LatestNewsTitleList\Default.cshtml"
WriteAttributeValue("", 386, item.NewsId, 386, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 398, "/", 398, 1, true);
#line 11 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\Components\LatestNewsTitleList\Default.cshtml"
WriteAttributeValue("", 399, item.Url, 399, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(409, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(411, 10, false);
#line 11 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\Components\LatestNewsTitleList\Default.cshtml"
                                                     Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(421, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 12 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\Components\LatestNewsTitleList\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(451, 47, true);
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewsWebsite.ViewModels.News.NewsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
