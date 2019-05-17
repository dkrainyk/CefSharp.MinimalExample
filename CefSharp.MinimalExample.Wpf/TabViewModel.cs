using System;
using System.Windows.Media;
using CefSharp.Wpf;

namespace CefSharp.MinimalExample.Wpf
{
    public class TabViewModel
    {
        public string Header { get; }

        public ChromiumWebBrowser Browser { get; }

        public TabViewModel(string header, string address)
        {
            Header = header;
            Browser = new ChromiumWebBrowser(address)
            {
                BrowserSettings = { WebSecurity = CefState.Disabled },
                Uid = Guid.NewGuid().ToString()
            };
            RenderOptions.SetBitmapScalingMode(Browser, BitmapScalingMode.NearestNeighbor);
        }
    }
}