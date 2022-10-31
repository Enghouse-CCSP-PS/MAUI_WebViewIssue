

namespace session1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

       
        Microsoft.Maui.Handlers.WebViewHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        {
            if (view is MyCustomWebView)
            {
#if ANDROID
                Android.Webkit.WebView webView = handler.PlatformView;
                webView.Settings.JavaScriptEnabled = true;
                webView.Settings.MixedContentMode = Android.Webkit.MixedContentHandling.AlwaysAllow;
                webView.Settings.PluginsEnabled = true;
                //webView.Settings.UserAgentString = 
                
                webView.Settings.AllowContentAccess = true;
                webView.Settings.LightTouchEnabled = true;
                webView.Settings.AllowFileAccess = true;
                webView.Settings.SetSupportMultipleWindows(true);
                webView.Settings.DatabaseEnabled = true;
                webView.Settings.DatabasePath = "/data/data/session/databases/";
                webView.Settings.DomStorageEnabled = true;
                webView.Settings.SetAppCacheEnabled(true);
                webView.Settings.SetAppCacheMaxSize(1024 * 1024 * 8);
                webView.Settings.SetAppCachePath("/data/data/session/cache/");
                webView.ClearCache(true);


#endif
            }
        });

    }
    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void OnResume()
    {
        base.OnResume();
    }

    protected override void OnSleep()
    {
        base.OnSleep();
    }

}
internal class MyCustomWebView : WebView
{
}
