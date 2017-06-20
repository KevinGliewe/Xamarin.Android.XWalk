using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Views;

namespace XWalk
{
    [Activity(Label = "XWalk", MainLauncher = true)]
    public class MainActivity : Org.Xwalk.Core.XWalkActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }

        protected override void OnXWalkReady()
        {
			var view = new RelativeLayout(this.BaseContext);
			var mp = ViewGroup.LayoutParams.MatchParent;
			var xwv = new Org.Xwalk.Core.XWalkView(this.BaseContext, this);
			view.AddView(xwv);
			this.AddContentView(view, new ViewGroup.LayoutParams(mp, mp));

			xwv.Load("https://jeromeetienne.github.io/AR.js/three.js/examples/mobile-performance.html", null);
        }
    }
}

