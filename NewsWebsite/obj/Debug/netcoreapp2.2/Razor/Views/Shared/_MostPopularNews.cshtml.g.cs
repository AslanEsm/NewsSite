#pragma checksum "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "591407849cf97369c31068e4293d1b00e18327e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MostPopularNews), @"mvc.1.0.view", @"/Views/Shared/_MostPopularNews.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_MostPopularNews.cshtml", typeof(AspNetCore.Views_Shared__MostPopularNews))]
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
#line 2 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
using NewsWebsite.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"591407849cf97369c31068e4293d1b00e18327e7", @"/Views/Shared/_MostPopularNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__MostPopularNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsWebsite.ViewModels.News.NewsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Model.First().ImageName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 424, true);
            WriteLiteral(@"    <div class=""single-widget border latest-video-widget mb-50"">
        <!-- Section Heading -->
        <div class=""section-heading style-2 mb-30"">
            <h4>محبوب ترین اخبار</h4>
            <div class=""line""></div>
        </div>

        <!-- Single Blog Post -->
        <div class=""single-post-area mb-30"">
            <!-- Post Thumbnail -->
            <div class=""post-thumbnail"">
                ");
            EndContext();
            BeginContext(507, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "591407849cf97369c31068e4293d1b00e18327e73983", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 517, "~/newsImage/", 517, 12, true);
#line 14 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
AddHtmlAttributeValue("", 529, Model.First().ImageName, 529, 24, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(585, 90, true);
            WriteLiteral("\r\n\r\n                <!-- Video Duration -->\r\n                <span class=\"video-duration\">");
            EndContext();
            BeginContext(676, 60, false);
#line 17 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
                                        Write(Model.First().PublishDateTime.ConvertMiladiToShamsi("HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(736, 124, true);
            WriteLiteral("</span>\r\n            </div>\r\n\r\n            <!-- Post Content -->\r\n            <div class=\"post-content\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 860, "\"", 901, 4);
            WriteAttributeValue("", 867, "/", 867, 1, true);
#line 22 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
WriteAttributeValue("", 868, Model.First(), 868, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 882, "/", 882, 1, true);
#line 22 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
WriteAttributeValue("", 883, Model.First().Url, 883, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(902, 21, true);
            WriteLiteral(" class=\"post-title\"> ");
            EndContext();
            BeginContext(924, 19, false);
#line 22 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
                                                                            Write(Model.First().Title);

#line default
#line hidden
            EndContext();
            BeginContext(943, 139, true);
            WriteLiteral(" </a>\r\n                <div class=\"post-meta d-flex\">\r\n                    <a href=\"#\"><i class=\"fa fa-comments-o\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(1083, 30, false);
#line 24 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
                                                                               Write(Model.First().NumberOfComments);

#line default
#line hidden
            EndContext();
            BeginContext(1113, 83, true);
            WriteLiteral("</a>\r\n                    <a href=\"#\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(1197, 27, false);
#line 25 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
                                                                        Write(Model.First().NumberOfVisit);

#line default
#line hidden
            EndContext();
            BeginContext(1224, 91, true);
            WriteLiteral("</a>\r\n                    <a href=\"#\"><i class=\"fa fa-thumbs-o-up\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(1316, 26, false);
#line 26 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
                                                                                Write(Model.First().NumberOfLike);

#line default
#line hidden
            EndContext();
            BeginContext(1342, 93, true);
            WriteLiteral("</a>\r\n                    <a href=\"#\"><i class=\"fa fa-thumbs-o-down\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(1436, 29, false);
#line 27 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
                                                                                  Write(Model.First().NumberOfDisLike);

#line default
#line hidden
            EndContext();
            BeginContext(1465, 68, true);
            WriteLiteral("</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
            EndContext();
#line 32 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
         foreach (var item in Model.Skip(1).Take(4))
        {

#line default
#line hidden
            BeginContext(1598, 117, true);
            WriteLiteral("            <div class=\"single-blog-post d-flex\">\r\n                <div class=\"post-thumbnail\">\r\n                    ");
            EndContext();
            BeginContext(1715, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "591407849cf97369c31068e4293d1b00e18327e710082", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1725, "~/newsImage/", 1725, 12, true);
#line 36 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
AddHtmlAttributeValue("", 1737, item.ImageName, 1737, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 36 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
AddHtmlAttributeValue("", 1759, item.ImageName, 1759, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1776, 92, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"post-content\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1868, "\"", 1903, 4);
            WriteAttributeValue("", 1875, "/News/", 1875, 6, true);
#line 39 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
WriteAttributeValue("", 1881, item.NewsId, 1881, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 1893, "/", 1893, 1, true);
#line 39 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
WriteAttributeValue("", 1894, item.Url, 1894, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1904, 21, true);
            WriteLiteral(" class=\"post-title\"> ");
            EndContext();
            BeginContext(1926, 15, false);
#line 39 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
                                                                          Write(item.ShortTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1941, 171, true);
            WriteLiteral(" </a>\r\n                    <div class=\"post-meta d-flex justify-content-between\">\r\n                        <a href=\"#\"><i class=\"fa fa-comments-o\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(2113, 21, false);
#line 41 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
                                                                                   Write(item.NumberOfComments);

#line default
#line hidden
            EndContext();
            BeginContext(2134, 87, true);
            WriteLiteral("</a>\r\n                        <a href=\"#\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(2222, 18, false);
#line 42 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
                                                                            Write(item.NumberOfVisit);

#line default
#line hidden
            EndContext();
            BeginContext(2240, 95, true);
            WriteLiteral("</a>\r\n                        <a href=\"#\"><i class=\"fa fa-thumbs-o-up\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(2336, 17, false);
#line 43 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
                                                                                    Write(item.NumberOfLike);

#line default
#line hidden
            EndContext();
            BeginContext(2353, 97, true);
            WriteLiteral("</a>\r\n                        <a href=\"#\"><i class=\"fa fa-thumbs-o-down\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(2451, 20, false);
#line 44 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
                                                                                      Write(item.NumberOfDisLike);

#line default
#line hidden
            EndContext();
            BeginContext(2471, 78, true);
            WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 48 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_MostPopularNews.cshtml"
        }

#line default
#line hidden
            BeginContext(2560, 12, true);
            WriteLiteral("    </div>\r\n");
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