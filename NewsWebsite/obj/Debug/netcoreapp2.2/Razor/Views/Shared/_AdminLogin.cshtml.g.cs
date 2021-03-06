#pragma checksum "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9eb18ebd56ee453995b67a4a9dd167736769be3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminLogin), @"mvc.1.0.view", @"/Views/Shared/_AdminLogin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AdminLogin.cshtml", typeof(AspNetCore.Views_Shared__AdminLogin))]
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
#line 1 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml"
using NewsWebsite.Services.Contracts;

#line default
#line hidden
#line 2 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml"
using NewsWebsite.Common;

#line default
#line hidden
#line 3 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml"
using NewsWebsite.Data.Contracts;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9eb18ebd56ee453995b67a4a9dd167736769be3", @"/Views/Shared/_AdminLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image placeholder"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/UserPic.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(192, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml"
   
    var user = await userManager.GetUserAsync(User);

#line default
#line hidden
            BeginContext(256, 1609, true);
            WriteLiteral(@"
<style>
.notification {
    display: inline-block;
    position: relative;
    padding: 0.2em 0.4em;
    background: #f5365c;
    border-radius: 0.2em;
    font-size: 1em;
    box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
}
    .notification.notify::before {
    animation: ring 1.5s ease;
}
.notification::before {
    display: block;
    content: ""\f086"";
    font-family: ""FontAwesome"";
    transform-origin: top center;
}
.notification::before, .notification::after {
    color: #fff;
    text-shadow: 0 1px 3px rgba(0, 0, 0, 0.3);
}

.notification.show-count::after {
    transform: scale(1);
    opacity: 1;
}
.notification::after {
    font-family: Arial;
    font-size: 0.6em;
    font-weight: 700;
    position: absolute;
    top: -10px;
    right: -10px;
    padding: 2px 4px;
    line-height: 100%;
    border: 2px #fff solid;
    border-radius: 60px;
    background: #3498db;
    opacity: 0;
    content: attr(data-count);
    opacity: 0;
    transform: scale(0.5);
    t");
            WriteLiteral(@"ransition: transform, opacity;
        transition-duration: 0s, 0s;
        transition-timing-function: ease, ease;
    transition-duration: 0s, 0s;
    transition-timing-function: ease, ease;
    transition-duration: 0.3s;
    transition-timing-function: ease-out;
}
.notification::before, .notification::after {
    color: #fff;
    text-shadow: 0 1px 3px rgba(0, 0, 0, 0.3);
}
</style>
<ul class=""navbar-nav align-items-center d-none d-md-flex"">
    <li>
        <a href=""/Admin/Comments/Index?isConfirm=false"" class=""notification notify show-count ml-4"" data-count=""");
            EndContext();
            BeginContext(1866, 43, false);
#line 70 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml"
                                                                                                           Write(commentRepository.CountUnAnsweredComments());

#line default
#line hidden
            EndContext();
            BeginContext(1909, 295, true);
            WriteLiteral(@"""></a>
    </li>
    <li class=""nav-item dropdown"">
        <a class=""nav-link pr-0"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            <div class=""media align-items-center"">
                <span class=""avatar avatar-sm rounded-circle"">
");
            EndContext();
#line 76 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml"
                     if (user.Image.HasValue())
                    {

#line default
#line hidden
            BeginContext(2276, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2300, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9eb18ebd56ee453995b67a4a9dd167736769be39162", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2334, "~/avatars/", 2334, 10, true);
#line 78 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml"
AddHtmlAttributeValue("", 2344, user.Image, 2344, 11, false);

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
            BeginContext(2357, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 79 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml"
                    }

                    else
                    {

#line default
#line hidden
            BeginContext(2433, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2457, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9eb18ebd56ee453995b67a4a9dd167736769be311157", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2517, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 84 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml"
                    }

#line default
#line hidden
            BeginContext(2542, 157, true);
            WriteLiteral("\r\n                </span>\r\n                <div class=\"media-body ml-2 d-none d-lg-block\">\r\n                    <span class=\"mb-0 text-sm  font-weight-bold\">");
            EndContext();
            BeginContext(2700, 14, false);
#line 88 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml"
                                                            Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2714, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2716, 13, false);
#line 88 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml"
                                                                            Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2729, 156, true);
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </a>\r\n        <div class=\"dropdown-menu dropdown-menu-arrow dropdown-menu-right\">\r\n            ");
            EndContext();
            BeginContext(2885, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9eb18ebd56ee453995b67a4a9dd167736769be313779", async() => {
                BeginContext(2983, 102, true);
                WriteLiteral("\r\n                <i class=\"ni ni-single-02\"></i>\r\n                <span>?????????? ????</span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "E:\ASP.NET Core Training\NewsWebsite-1\NewsWebsite\Views\Shared\_AdminLogin.cshtml"
                                                                                        WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3089, 64, true);
            WriteLiteral("\r\n            <div class=\"dropdown-divider\"></div>\r\n            ");
            EndContext();
            BeginContext(3153, 271, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9eb18ebd56ee453995b67a4a9dd167736769be316639", async() => {
                BeginContext(3221, 196, true);
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-link m-0 font-weight-normal dropdown-item\">\r\n                    <i class=\"ni ni-user-run\"></i> ????????\r\n                </button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3424, 34, true);
            WriteLiteral("\r\n        </div>\r\n    </li>\r\n</ul>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICommentRepository commentRepository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IApplicationUserManager userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
