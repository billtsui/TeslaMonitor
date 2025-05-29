using TeslaMonitor.Business;

namespace TeslaMonitor.View
{
    public partial class Login : Form
    {
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
            string redirectUri = "https://auth.tesla.com/void/callback";
            if (url.StartsWith(redirectUri) && url.Contains("code="))
            {
                 _loginBusiness.GetCode(url);
                 _loginBusiness.GetToken();
            }
        }
    }
}
