#pragma checksum "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\AngleSharpSpiderDemo\Views\SpiderBlog\IndexAsync.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e2429770a6888c866e986d2ea22a4d6d3bda20d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SpiderBlog_IndexAsync), @"mvc.1.0.view", @"/Views/SpiderBlog/IndexAsync.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SpiderBlog/IndexAsync.cshtml", typeof(AspNetCore.Views_SpiderBlog_IndexAsync))]
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
#line 1 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\AngleSharpSpiderDemo\Views\_ViewImports.cshtml"
using AngleSharpSpiderDemo;

#line default
#line hidden
#line 2 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\AngleSharpSpiderDemo\Views\_ViewImports.cshtml"
using AngleSharpSpiderDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2429770a6888c866e986d2ea22a4d6d3bda20d", @"/Views/SpiderBlog/IndexAsync.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fed9f24e72daeaf0a63295edd2b2894cab4db31a", @"/Views/_ViewImports.cshtml")]
    public class Views_SpiderBlog_IndexAsync : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<string, string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\AngleSharpSpiderDemo\Views\SpiderBlog\IndexAsync.cshtml"
  
    ViewData["Title"] = "IndexAsync";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 27, true);
            WriteLiteral("<h2>爬取博客园首页文章名称和链接</h2>\r\n\r\n");
            EndContext();
#line 9 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\AngleSharpSpiderDemo\Views\SpiderBlog\IndexAsync.cshtml"
 foreach (var item in Model)
{
    string title = item.Key;
    string href = item.Value;

#line default
#line hidden
            BeginContext(252, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 258, "\"", 270, 1);
#line 13 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\AngleSharpSpiderDemo\Views\SpiderBlog\IndexAsync.cshtml"
WriteAttributeValue("", 265, href, 265, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(271, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(273, 5, false);
#line 13 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\AngleSharpSpiderDemo\Views\SpiderBlog\IndexAsync.cshtml"
               Write(title);

#line default
#line hidden
            EndContext();
            BeginContext(278, 18, true);
            WriteLiteral("</a>\r\n    <br />\r\n");
            EndContext();
#line 15 "E:\GithubCode\AngleSharpSpider\AngleSharpSpider\AngleSharpSpiderDemo\Views\SpiderBlog\IndexAsync.cshtml"
}

#line default
#line hidden
            BeginContext(299, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string, string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
