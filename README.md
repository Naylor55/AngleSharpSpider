# AngleSharpSpider
使用AngleSharp爬取一些东西



## 集福助手

### 背景

又到了一年一度得支付宝集福活动了，虽然现在得集福变得越来越容易，添加了更多得广告，没有太多意思，但是依然受到了广大网友的积极参与，可能是为了集福成功分享一个朋友圈，可能是为了情怀，反正不是为了那几毛钱。

本助手的作用就是快速找到不同的福字，用户运行次程序后只需点击下一张就可获取一个全新的福字。


### 介绍

集福助手采用WPF框架开发，目前仅支持Window平台运行，基于.NetFramework4.8开发，爬虫框架选用的是AngleSharp。

打开界面左边显示的是福字图片，用Image控件承载，右边是下一张的按钮，底部是使用说明。

为尽可能避免一切可能发生的不可控问题，本程序爬取间隙会设置程序休眠1s，当点击下一张后没有反应需要耐心等待几秒中。


[![pSmLp9g.png](https://s1.ax1x.com/2023/01/11/pSmLp9g.png)](https://imgse.com/i/pSmLp9g)




### 代码
#### xaml代码

~~~


<Window x:Class="CollectionHappiness.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:CollectionHappiness"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800" Loaded="Window_Loaded">
    <Grid>
        <StackPanel>
            <Grid>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="5*"></ColumnDefinition>
                    <ColumnDefinition Width="1*"></ColumnDefinition>
                </Grid.ColumnDefinitions>
                <Border  Grid.Column="0">
                    <Image  Height="300" Margin="20" Name="img" ></Image>
                </Border>
                <Button Grid.Column="1" Width="100" Height="80" Name="btn_next" Content="下一张" Click="btn_next_Click"></Button>
            </Grid>
            <Border>
                <TextBlock Text="使用说明：使用AngleSharp爬取视觉中国网站得福字；点击下一张重新获取一个福字。有bug 欢迎交流" ></TextBlock>
            </Border>
        </StackPanel>
    </Grid>
</Window>



~~~


#### cs代码

~~~


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
            var url = "https://www.vcg.com/creative-image/1694/";
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



~~~


### 说明
集福助手还有很多bug和隐藏问题，欢迎大家指出和交流，不喜勿喷。

