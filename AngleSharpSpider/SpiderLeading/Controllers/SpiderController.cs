using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AngleSharp;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
            List<Models.SkuPhotoInfo> model = await getSkuPhotoInfoAsync(skuIds);
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