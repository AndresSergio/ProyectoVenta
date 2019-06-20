using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using MiChofer.UI.CustomRenderer;
using MiChofer.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(GradientStackLayout), typeof(GradientStackLayoutRenderer))]
namespace MiChofer.Droid.CustomRenderer
{
    class GradientStackLayoutRenderer : VisualElementRenderer<StackLayout>
    {
        public GradientStackLayoutRenderer(Context context) : base(context)
        {
        }

        private Color StartColor
        {
            get;
            set;
        }
        private Color EndColor
        {
            get;
            set;
        }

        private float LeftBottomCornerRadius { get; set; }


        protected override void DispatchDraw(global::Android.Graphics.Canvas canvas)
        {
            #region for Vertical Gradient      
            //var gradient = new Android.Graphics.LinearGradient(0, 0, 0, Height,  
            #endregion
            #region for Horizontal Gradient      
            var gradient = new Android.Graphics.LinearGradient(0, 0, Width, 0,
            #endregion
                this.StartColor.ToAndroid(),
             this.EndColor.ToAndroid(),
             Android.Graphics.Shader.TileMode.Mirror);

            var paint = new Android.Graphics.Paint()
            {
                Dither = true,
            };
            paint.SetShader(gradient);
            canvas.DrawRoundRect(0.0f, -LeftBottomCornerRadius, (float)Width + LeftBottomCornerRadius, (float)Height, LeftBottomCornerRadius, LeftBottomCornerRadius, paint);
            base.DispatchDraw(canvas);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<StackLayout> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }
            try
            {
                var stack = e.NewElement as GradientStackLayout;
                this.StartColor = stack.StartColor;
                this.EndColor = stack.EndColor;
                this.LeftBottomCornerRadius = stack.LeftBottomCornerRadius;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(@"ERROR:", ex.Message);
            }
        }

    }
}