/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;
using FaucetCryptoBot.Engine.Abstract;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Cookie = OpenQA.Selenium.Cookie;


namespace FaucetCryptoBot.Engine.Concrete
{
    public class BrowserManager : IBrowserService
    {

        /// <summary>
        /// Tarayıcı ayarlarını yükleme
        /// </summary>
        public void LoadSetting()
        {


            // Driver servis ayarları
            Constants.Service.HideCommandPromptWindow = true; // komut satırı gizleme

            // Kullanıcı Profili
            var userPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\";
            if (Directory.Exists(userPath + "Profile 1"))
            {
                userPath += "Profile 1";
            }
            else
            {
                userPath += "Profile 2";
            }


            // Parametreler
            //Constants.Options.AddArguments("--incognito"); // gizli tarayıcı
            Constants.Options.AddArguments("--start-maximized"); // tam ekran
            Constants.Options.AddArgument($@"--user-data-dir={userPath}"); // Chrome profil
            Constants.Options.AddArgument("--disable-gpu"); // gpu kullanımını kaldırma
            Constants.Options.AddExcludedArgument("enable-automation"); // info bar gizleme
            Constants.Options.AddArgument("--lang=en-US"); // dil ayarı
            Constants.Options.AddArgument("--disable-default-apps"); // varsayılan eklentileri kaldırma
            Constants.Options.AddArgument("--disable-extensions"); // eklentileri kaldırma
            //Constants.Options.AddAdditionalCapability("useAutomationExtension", false); // otomatik eklentiler  
            Constants.Options.AddArgument("--ignore-certificate-errors"); // serfitika hatalarını yoksay
            //Constants.Options.AddArgument("--auto-open-devtools-for-tabs"); // geliştirici araçları
            
            // Sürücü ve Ayarları aktar
            Constants.Driver = new ChromeDriver(Constants.Service, Constants.Options);

            // DevTools
            //IDevTools devTools = (IDevTools) Constants.Driver;
            //Constants.Session = devTools.CreateDevToolsSession();
            //NetworkInterception();

            // Sürücü bekletme
            Constants.DriverWait = new WebDriverWait(
                Constants.Driver,
                new TimeSpan(0, 0, Constants.DriverWaitTime)
            );

            // Captcha Resolver
            Constants.LoginService.ResolverService.SetDriver(Constants.Driver);
        }

        /// <summary>
        /// Tarayıcıyı kapatma
        /// </summary>
        public void BrowserQuit()
        {
            var task = Task.Run(() =>
            {
                if (Constants.Driver == null) return;
                try
                {
                    Constants.Driver.Quit();
                    Constants.Driver.Close();
                    Constants.Driver.Dispose();
                }
                catch
                {
                    // ignored
                    Constants.Driver.Quit();
                }
            });
        }

        /// <summary>
        /// Tarayıcıda site açma
        /// </summary>
        /// <param name="url">Site url</param>
        public void Request(string url)
        {
            // Tarayıcıyı aç
            Constants.Driver.Url = url;
            //Constants.Driver.Navigate().GoToUrl(url);
        }

        /// <summary>
        /// Sayfanın kaynak kodu
        /// </summary>
        /// <returns></returns>
        public string PageSource()
        {
            return Constants.Driver != null ? Constants.Driver.PageSource : null;
        }

        /// <summary>
        /// Sayfanın cookie bilgisi
        /// </summary>
        /// <returns></returns>
        public ReadOnlyCollection<Cookie> GetCookie()
        {
            var cookies = Constants.Driver.Manage().Cookies.AllCookies;
            return cookies;
        }


        public void NetworkInterception()
        {
            //Constants.Session.Network.Enable(new EnableCommandSettings());
        }

    }
}
