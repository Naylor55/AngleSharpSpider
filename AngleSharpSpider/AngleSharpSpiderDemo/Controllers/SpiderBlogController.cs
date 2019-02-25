using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AngleSharp;

namespace AngleSharpSpiderDemo.Controllers
{
    public class SpiderBlogController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            var config = Configuration.Default.WithDefaultLoader();
            var address = "https://www.cnblogs.com/";
            var document = await BrowsingContext.New(config).OpenAsync(address);
            var cellSelector = ".post_item";
            var cells = document.QuerySelectorAll(cellSelector);
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach (var item in cells)
            {
                string title = item.QuerySelector(".titlelnk").TextContent;
                string href = item.QuerySelector(".titlelnk").GetAttribute("href");
                dic.Add(title, href);
            }
            return View(dic);
        }
    }
}