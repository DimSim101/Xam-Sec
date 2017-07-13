using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Net.Security;
using Square.OkHttp3;

namespace Xam_Sec.Droid
{
	[Activity (Label = "Xam_Sec", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new Xam_Sec.App ());

            System.IO.Stream stream = new System.IO.MemoryStream();
            SslStream ns = new SslStream(stream);

            Console.WriteLine("SYSTEM.NET.SECURITY: SslStream = " + ns.ToString());

            CertificatePinner.Builder cpBuilder = new CertificatePinner.Builder();
            CertificatePinner certPinner = cpBuilder.Build();

            Console.WriteLine("OKHTTP3: CertificatePinner = " + certPinner.ToString());

            Console.ReadLine();
		}
	}
}

