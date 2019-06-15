﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;

namespace HtmlImage.Droid
{
    public class renderimg : Java.Lang.Object, Html.IImageGetter
    {
        public Drawable GetDrawable(string source)
        {
            Drawable drawable;
            Bitmap bitMap;
            BitmapFactory.Options bitMapOption;
            try
            {
                bitMapOption = new BitmapFactory.Options();
                bitMapOption.InJustDecodeBounds = false;
                bitMapOption.InPreferredConfig = Bitmap.Config.Argb4444;
                bitMapOption.InPurgeable = true;
                bitMapOption.InInputShareable = true;
                source = "https://cdn.vox-cdn.com/thumbor/Yy4jX6Xc7l53PnJynUc2I2oTmiM=/0x0:2040x1360/320x0/filters:focal(0x0:2040x1360):no_upscale()/cdn.vox-cdn.com/uploads/chorus_asset/file/16257174/vpavic_190510_3415_0187.jpg";
                var url = new Java.Net.URL(source);

                bitMap = BitmapFactory.DecodeStream(url.OpenStream(), null, bitMapOption);
                drawable = new BitmapDrawable(bitMap);
                //var url = new Java.Net.URL(source);
                //drawable =  Drawable.CreateFromStream(url.OpenStream(), null);
            }
            catch (Exception ex)
            {
                return null;
            }

            drawable.SetBounds(0, 0, bitMapOption.OutWidth, bitMapOption.OutHeight);
            return drawable;
        }

        public new IntPtr Handle
        {
            get { return base.Handle; }
        }

        public new void Dispose()
        {
            base.Dispose();
        }
    }
}