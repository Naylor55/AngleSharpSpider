#pragma checksum "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78629dfe4cee56fd6c761c647bae22b67a358886"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Spider_SkuPhotoAsync), @"mvc.1.0.view", @"/Views/Spider/SkuPhotoAsync.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Spider/SkuPhotoAsync.cshtml", typeof(AspNetCore.Views_Spider_SkuPhotoAsync))]
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
#line 1 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\_ViewImports.cshtml"
using SpiderLeading;

#line default
#line hidden
#line 2 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\_ViewImports.cshtml"
using SpiderLeading.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78629dfe4cee56fd6c761c647bae22b67a358886", @"/Views/Spider/SkuPhotoAsync.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"596e2a1ce12d20681124d6a71ddc43db357301e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Spider_SkuPhotoAsync : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SpiderLeading.Models.SkuPhotoInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
  
    ViewData["Title"] = "SkuPhotoAsync";

#line default
#line hidden
            BeginContext(100, 30, true);
            WriteLiteral("\r\n\r\n<h2>SkuPhotoAsync</h2>\r\n\r\n");
            EndContext();
#line 10 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
 if (Model != null && Model.Count > 0)
{

#line default
#line hidden
            BeginContext(173, 46, true);
            WriteLiteral("    <div class=\"panel-group\" id=\"accordion\">\r\n");
            EndContext();
#line 13 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
         foreach (SpiderLeading.Models.SkuPhotoInfo item in Model)
        {

#line default
#line hidden
            BeginContext(298, 262, true);
            WriteLiteral(@"            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <h4 class=""panel-title"">
                        <a data-toggle="""" data-parent=""""
                           href=""#"">
                            ");
            EndContext();
            BeginContext(561, 10, false);
#line 20 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
                       Write(item.skuId);

#line default
#line hidden
            EndContext();
            BeginContext(571, 58, true);
            WriteLiteral("\r\n                        </a>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 629, "\"", 648, 1);
#line 22 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
WriteAttributeValue("", 636, item.skuUrl, 636, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(649, 228, true);
            WriteLiteral(" target=\"_blank\">电商网站链接</a>\r\n                    </h4>\r\n                </div>\r\n                <div id=\"collapseOne\" class=\"panel-collapse collapse in\">\r\n                    <div class=\"panel-body\">\r\n                        <p>");
            EndContext();
            BeginContext(878, 15, false);
#line 27 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
                      Write(item.photoTitle);

#line default
#line hidden
            EndContext();
            BeginContext(893, 82, true);
            WriteLiteral("</p>\r\n                        <p>\r\n                            <span>高：</span> <b>");
            EndContext();
            BeginContext(976, 16, false);
#line 29 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
                                          Write(item.photoHeight);

#line default
#line hidden
            EndContext();
            BeginContext(992, 53, true);
            WriteLiteral("</b>\r\n                            <span>宽：</span> <b>");
            EndContext();
            BeginContext(1046, 15, false);
#line 30 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
                                          Write(item.photoWidth);

#line default
#line hidden
            EndContext();
            BeginContext(1061, 99, true);
            WriteLiteral("</b>\r\n                        </p>\r\n                        <div>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1160, "\"", 1180, 1);
#line 33 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
WriteAttributeValue("", 1166, item.photoUrl, 1166, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1181, 109, true);
            WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 38 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
        }

#line default
#line hidden
            BeginContext(1301, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 40 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"


}
else
{
    if (ViewBag.ErrorMsg != null)
    {

#line default
#line hidden
            BeginContext(1371, 17, true);
            WriteLiteral("        <p>=_=*  ");
            EndContext();
            BeginContext(1389, 16, false);
#line 47 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
            Write(ViewBag.ErrorMsg);

#line default
#line hidden
            EndContext();
            BeginContext(1405, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 48 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
    }
    else
    {


#line default
#line hidden
            BeginContext(1437, 31, true);
            WriteLiteral("        <p>=_=*     爬取失败。</p>\r\n");
            EndContext();
#line 53 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\SpiderLeading\Views\Spider\SkuPhotoAsync.cshtml"
    }
}

#line default
#line hidden
            BeginContext(1478, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SpiderLeading.Models.SkuPhotoInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
