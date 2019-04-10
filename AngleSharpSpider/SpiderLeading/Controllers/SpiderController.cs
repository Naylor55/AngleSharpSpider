using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using SpiderLeading.Models;

namespace SpiderLeading.Controllers
{
    public class SpiderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SkuPhotoAsync(string skuIds)
        {
            List<Models.SkuPhotoInfo> model = new List<Models.SkuPhotoInfo>();
            if (!string.IsNullOrEmpty(skuIds))
            {
                string[] skuArray = skuIds.Split(',');
                if (skuArray != null && skuArray.Length > 0)
                {
                    foreach (string item in skuArray)
                    {
                        List<Models.SkuPhotoInfo> data = await getSkuPhotoInfoAsync(item);
                        foreach (SkuPhotoInfo skuPhotoInfo in data)
                        {
                            model.Add(skuPhotoInfo);
                        }
                    }
                }
                else
                {
                    ViewBag.ErrorMsg = "输入有问题。必须是以英文逗号分隔的sku编号";
                }
            }
            else
            {
                ViewBag.ErrorMsg = "输入不可为空";
            }
            return View(model);
        }

        private async Task<List<Models.SkuPhotoInfo>> getSkuPhotoInfoAsync(string skuid)
        {
            List<Models.SkuPhotoInfo> skuPhotoInfos = new List<Models.SkuPhotoInfo>();
            try
            {
                var config = Configuration.Default.WithDefaultLoader();
                var address = "https://66123123.com/Goods/GoodsDetail?id=" + skuid;
                var context = BrowsingContext.New(config);
                AngleSharp.Dom.Document document = (AngleSharp.Dom.Document)await context.OpenAsync(address);
                //AngleSharp.Html.Dom.IHtmlDivElement skuIconImgDoc = (AngleSharp.Html.Dom.IHtmlDivElement)document.QuerySelector(".b-img");
                //AngleSharp.Html.Dom.IHtmlDivElement skuDetailImgDoc = (AngleSharp.Html.Dom.IHtmlDivElement)document.QuerySelector(".showimg");            
                AngleSharp.Dom.IHtmlCollection<AngleSharp.Html.Dom.IHtmlImageElement> images = document.Images;
                List<AngleSharp.Html.Dom.IHtmlImageElement> imgs =
                    images.Where(i => i.AlternativeText == "商品图片" || i.AlternativeText == "商品详情图片").ToList();
                foreach (AngleSharp.Html.Dom.IHtmlImageElement item in imgs)
                {
                    Models.SkuPhotoInfo skuPhotoInfo = new Models.SkuPhotoInfo
                    {
                        skuId = skuid,
                        photoUrl = item.Source,
                        photoTitle = item.AlternativeText,
                        skuUrl = "https://66123123.com/Goods/GoodsDetail?id=" + skuid
                    };
                    WebRequest request = WebRequest.Create(item.Source);
                    request.Credentials = CredentialCache.DefaultCredentials;
                    Stream s = request.GetResponse().GetResponseStream();
                    System.Drawing.Image image = System.Drawing.Image.FromStream(s);
                    s.Close();
                    skuPhotoInfo.photoHeight = image.Height;
                    skuPhotoInfo.photoWidth = image.Width;
                    skuPhotoInfos.Add(skuPhotoInfo);
                }
            }
            catch (Exception ex)
            {
                string errorMsg = "爬取图片报异常：" + ex.Message;
            }
            return skuPhotoInfos;
        }
    }
}