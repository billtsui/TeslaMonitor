using Microsoft.Web.WebView2.WinForms;
using TeslaMonitor.Business;

namespace TeslaMonitor.View
{
    public partial class Login : Form
    {
        private const string RedirectUri = "https://auth.tesla.com/void/callback";
        private LoginBusiness? _loginBusiness;
        public Login()
        {
            InitializeComponent();
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            _loginBusiness = new LoginBusiness();
            await webView2.EnsureCoreWebView2Async(null);
            webView2.CoreWebView2.CookieManager.DeleteAllCookies();
            webView2.Source = new Uri(_loginBusiness.GetLoginUrlForWebView());

        }

        private void webView2_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            var url = e.Uri.ToString();
            if (url.StartsWith(RedirectUri) && url.Contains("code="))
            {
                _loginBusiness.GetCode(url);
                _loginBusiness.tokens = _loginBusiness.GetToken().Result;
            }
        }

        private void webView2_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                ((WebView2)sender).ExecuteScriptAsync("document.querySelector('body').style.overflow='scroll';var style=document.createElement('style');style.type='text/css';style.innerHTML='::-webkit-scrollbar{display:none}';document.getElementsByTagName('body')[0].appendChild(style)");
            }
        }
    }
}
