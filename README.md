# Xamarin.Android Crosswalk Binding

An example Project to embed a [Crosswalk](https://crosswalk-project.org/) View into your Android App.

## Getting Started

The XWalk.Binding contains the Bindings to the Android Library and the Library (AAR) itself. If you want to use it, you can just copy it into your Project.

### Usage

An Example how to use the `Org.Xwalk.Core.XWalkView`:

```Java
using Android.App;
using Android.Widget;
using Android.OS;
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
```

This embeds a Crosswalk View into an Activity and navigates to the [AR.JS](https://github.com/jeromeetienne/AR.js) example which uses the WebRTC API to access the Camera. So you should add the `android.permission.CAMERA` permission to your `AndroidManifest.xml` file to run this example.

## Permissions

According to the [Crosswalk Documentation](https://crosswalk-project.org/documentation/android/embedding_crosswalk.html), the minimal Permissions required to run are:

```xml
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
<uses-permission android:name="android.permission.INTERNET" />
<uses-permission android:name="android.permission.ACCESS_WIFI_STATE" />
```

If you want to access Hardware components, you have to add the permission accordingly to your `AndroidManifest.xml` file.

## Authors

* **Kevin Gliewe** - [KevinGliewe](https://github.com/KevinGliewe)

## Inspiration

I took a lot of inspiration from the [Xamarin.CrossWalk](https://github.com/Youscribe/Xamarin.CrossWalk) Project from [kYann](https://github.com/kYann).
Thank you for your Work.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details