using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using HtmlImage;
using HtmlImage.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(HtmlLabel), typeof(HtmlLabelRenderer))]
namespace HtmlImage.Droid
{
    public class HtmlLabelRenderer : LabelRenderer
    {

        public HtmlLabelRenderer(Context context) : base(context)
        {
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (!string.IsNullOrEmpty(Element.Text))
                Control?.SetText(GetText(), TextView.BufferType.Spannable);
        }


        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == Label.TextProperty.PropertyName)
            {
                if (!string.IsNullOrEmpty(Element.Text))
                    Control?.SetText(GetText(), TextView.BufferType.Spannable);

            }
        }

        [Obsolete]
        private ISpanned GetText()
        {
            //renderimg.GetDrawable(Element.Text);
            return (int)Build.VERSION.SdkInt >= 24
                ? Html.FromHtml(Element.Text, FromHtmlOptions.ModeLegacy, new renderimg(), null)
                : Html.FromHtml(Element.Text, new renderimg(), null);
        }
    }
}