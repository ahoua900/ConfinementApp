using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MessAp.Renderers;
using MessAp.Droid.Renderers;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Xamarin.Forms;
using Android.Views;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof (BorderlessEntry), typeof(BorderlessEntryRendere))]
namespace MessAp.Droid.Renderers
{
   public class BorderlessEntryRendere : EntryRenderer
    {
        public BorderlessEntryRendere(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }

   
}