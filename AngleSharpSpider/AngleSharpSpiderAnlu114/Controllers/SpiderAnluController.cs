using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharpSpiderAnlu114.Models;

namespace AngleSharpSpiderAnlu114.Controllers
{
    public class SpiderAnluController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            var config = Configuration.Default.WithDefaultLoader();
            var address = "http://www.anlu114.com/job//";
            var document = await BrowsingContext.New(config).OpenAsync(address);
            var cellSelector = ".css3";
            var cells = document.QuerySelectorAll(cellSelector);
            List<Anlu114Model> list = new List<Anlu114Model>();
            foreach (var item in cells)
            {
                Anlu114Model model = new Anlu114Model();
                model.type = "安陆招聘信息";
                Dictionary<string, string> dic = new Dictionary<string, string>();
                string name = string.Empty;
                if (item.FirstElementChild != null)
                {
                    name = item.QuerySelector("b").TextContent;
                }
                else
                {
                    name = item.InnerHtml;
                }
                string href = "http://www.anlu114.com" + item.GetAttribute("href");
                dic.Add(href, name);
                model.item = dic;
                list.Add(model);
            }
            return View(list);
        }
    }
}