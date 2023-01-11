using AngleSharp;
using AngleSharp.Common;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CollectionHappiness
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        const string prefix = "https:";

        static IHtmlCollection<AngleSharp.Html.Dom.IHtmlImageElement> images;

        static List<int> usedList = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IConfiguration config = Configuration.Default.WithDefaultLoader().WithDefaultCookies();            
            var url = "https://www.vcg.com/creative-image/fu/";
            var context = BrowsingContext.New(config);
            Document doc = (Document)await context.OpenAsync(url);
            images = doc.Images;
            if (null != images && images.Length > 1)
            {
                this.img.Source = this.GetImg(images);
            }
        }


        private BitmapImage GetImg(IHtmlCollection<AngleSharp.Html.Dom.IHtmlImageElement> images)
        {
            int length = images.Length;
            Random random = new Random();
            int index = random.Next(0, length);
            AngleSharp.Html.Dom.IHtmlImageElement imgElement = images.GetItemByIndex(index);
            string dataSrc = imgElement.GetAttribute("data-src");
            if (null == dataSrc || dataSrc.Length <= 0 || usedList.Contains(index))
            {
                Thread.Sleep(1000); 
                GetImg(images);
            }
            usedList.Add(index);
            return new BitmapImage(new Uri("https:" + dataSrc));
        }

        private void btn_next_Click(object sender, RoutedEventArgs e)
        {
            this.btn_next.IsEnabled = false;
            this.img.Source = this.GetImg(images);
            Thread.Sleep(1000);
            this.btn_next.IsEnabled = true;
        }
    }
}
