/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using FaucetCryptoBot.Engine.Abstract;
using FaucetCryptoBot.Engine.Concrete;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FaucetCryptoBot.Engine
{
    public static class Constants
    {
        /// <summary>
        /// Chrome Driver, Service and Settings
        /// </summary>
        //public static DevToolsSession Session;
        public static IWebDriver Driver;
        public static ChromeDriverService Service = ChromeDriverService.CreateDefaultService();
        public static ChromeOptions Options = new ChromeOptions();
        public static WebDriverWait DriverWait;
        public static int DriverWaitTime = 15; // seconds


        /// <summary>
        /// Manager Classes
        /// </summary>
        public static IBrowserService BrowserService = new BrowserManager();
        public static ILoginService LoginService = new LoginManager();


        /// <summary>
        /// General Settings
        /// </summary>
        //public static readonly string CaptchaAudioFilePath = Path.GetTempPath() + "audio.mp3";
        public static int DelayTime1 = 1000;
        public static int DelayTime2 = 2000;
        public static string AudioCaptchaWarning = @"AudioCaptchaWarning.mp3";


        /// <summary>
        /// Faucet Crypto API
        /// </summary>
        public static string ApiUrl = "https://www.faucetcrypto.com/api/";
        public static string ApiHomeUrl = ApiUrl + "home";
        public static string ApiDetailsUrl = ApiUrl + "details";


        /// <summary>
        /// Faucet Crypto Url
        /// </summary>
        public static string BaseUrl = "https://www.faucetcrypto.com";
        public static string DashboardUrl = BaseUrl + "/dash";
        public static string HomeUrl = DashboardUrl + "/home";


        /// <summary>
        /// Login
        /// </summary>
        public static string LoginUrl = BaseUrl + "/auth/login";
        public static string LoginXpathEmail = "//input[@name='email']";
        public static string LoginXpathPassword = "//input[@name='password']";
        public static string LoginXpathSubmit = "//span[contains(text(),'Login')]";
        public static string LoginXpathStatus = "//div[@class='vx-card__body']//h5";
        public static string LoginXpathStatusWord = "Welcome Back";


        /// <summary>
        /// Ads General Xpath
        /// </summary>
        public static string AdsCaptchaAlert = "Please click on the similar buttons in the following order:";
        public static string AdsXpathGetWaitingTime = "//*[@class='mb-base']//button";
        public static string AdsXpathClick = "//*[@class='mb-base']//button";



        /// <summary>
        /// Ready To Claim
        /// </summary>
        public static string ReadyToClaimUrl = DashboardUrl + "/main-claim";


        /// <summary>
        /// Shortlinks
        /// </summary>
        public static string ShortLinksUrl = DashboardUrl + "/shortlinks";
        public static string ShortLinksXpathAdsList = "//table//tbody";
        public static string ShortLinksXpathAdsStatus = "//tr[{0}]//td[5]//span[1]//span[1]";
        public static string ShortLinksXpathAdsClick = "//tr[{0}]//td[6]//span[1]//button[1]";
        public static string ShortLinksXpathClickHere = "//button[@id='showTimerText']";
        public static string ShortLinksXpathTime = "//span[@id='timer']";
        public static string ShortLinksXpathClickContinue = "//button[@id='main-button']";


        /// <summary>
        /// PTC Adverts
        /// </summary>
        public static string PtcAdsUrl = DashboardUrl + "/ptc-ads";
        public static string PtcXpathFirstAdsClick = "//body//div//div//div//div//div//div//div//div[1]//div[1]//div[1]//div[1]//div[2]//button[1]";
        public static string PtcXpathWaitingTime = "//header//div[2]//button[1]";
        public static string PtcXpathClickContinue = "//a[@class='vs-component vs-button shadow-md ml-5 vs-button-primary vs-button-filled']";




    }

}
