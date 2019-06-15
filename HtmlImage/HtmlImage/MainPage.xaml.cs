using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HtmlImage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            myhtml.Text = @"<p>this is text with image
                <img src='https://cdn.vox-cdn.com/thumbor/Yy4jX6Xc7l53PnJynUc2I2oTmiM=/0x0:2040x1360/320x0/filters:focal(0x0:2040x1360):no_upscale()/cdn.vox-cdn.com/uploads/chorus_asset/file/16257174/vpavic_190510_3415_0187.jpg'></p>";
        }
    }
}
