/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using System;
using System.Linq;
using System.Threading.Tasks;
using FaucetCryptoBot.Engine.Abstract;
using FaucetCryptoBot.Engine.Entities;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using reCAPTCHA.Resolver.Core;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using ResponseStatus = FaucetCryptoBot.Engine.Entities.ResponseStatus;

namespace FaucetCryptoBot.Engine.Concrete
{
    public class LoginManager : ILoginService
    {
        private readonly IApiService _apiService = new ApiManager();

        /// <summary>
        /// Api token bilgilerini aktar
        /// </summary>
        public void SetApiToken(string authorization)
        {
            _apiService.Authorization = authorization;
        }

        /// <summary>
        /// Captcha çözücü
        /// </summary>
        public ResolverService ResolverService { get; set; }

        /// <summary>
        /// Giriş durumu
        /// </summary>
        /// <returns></returns>
        private static bool LoginStatus()
        {
            try
            {
                var status = Constants.DriverWait.Until(
                    ExpectedConditions.ElementToBeClickable(
                        By.XPath(Constants.LoginXpathStatus)
                    )).Text;

                if (string.IsNullOrEmpty(status))
                {
                    status = "";
                }

                return status.IndexOf(Constants.LoginXpathStatusWord, StringComparison.Ordinal) != -1;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Giriş yap metodu
        /// </summary>
        /// <param name="loginProperty">Kullanıcı bilgileri</param>
        /// <returns></returns>
        public async Task<Response> Login(LoginProperty loginProperty)
        {
            // Çıktı
            var response = new Response();

            //// without an element
            //new Actions(Constants.Driver)
            //    .SendKeys(Keys.Control + Keys.Shift + "ı")
            //    .Perform();

            Constants.BrowserService.Request(Constants.LoginUrl); // sayfayı aç
            await Task.Delay(Constants.DelayTime1); // bekle

            // Giriş açık mı kontrol et
            if (LoginStatus())
            {
                // Evet
                response.Message = "Giriş yapıldı";
                response.Code = ResponseStatus.Success;
            }
            else
            {
                // Hayır

                // Epostayı aktar
                Constants.Driver.FindElement(By.XPath(Constants.LoginXpathEmail))
                    .SendKeys(loginProperty.Username);
                await Task.Delay(Constants.DelayTime1);

                // Şifreyi aktar
                Constants.Driver.FindElement(By.XPath(Constants.LoginXpathPassword))
                    .SendKeys(loginProperty.Password);
                await Task.Delay(Constants.DelayTime1);

                // Giriş yapa tıkla
                Constants.Driver.FindElement(By.XPath(Constants.LoginXpathSubmit))
                    .Click();

                // Captcha çözümle
                response.Message = CaptchaResolve();
                await Task.Delay(Constants.DelayTime2);

                // Giriş kontrolü yap
                if (LoginStatus())
                {
                    response.Message = "Giriş yapıldı";
                    response.Code = ResponseStatus.Success;
                }
                else
                {
                    response.Message = "Giriş yapılamadı";
                    response.Code = ResponseStatus.Error;
                }
            }
            return response;
        }

        /// <summary>
        /// Captcha çözücü metot
        /// </summary>
        /// <returns></returns>
        private static string CaptchaResolve()
        {
            if (Constants.BrowserService.PageSource().IndexOf("g-recaptcha", StringComparison.Ordinal) != -1)
            {
                var result = Constants.LoginService.ResolverService.GetResolve();
                return result;
            }
            else
            {
                return "false";
            }
        }


        /// <summary>
        /// Açık oturumun reklam bilgileri
        /// </summary>
        /// <returns></returns>
        public async Task<AdsInfoProperty> CurrentAdsInfo()
        {
            var info = new AdsInfoProperty();

            var currentTabUrl = Constants.Driver.Url;

            try
            {
                // Sayfaların birinde DashboardUrl geçiyorsa bilgileri çek
                if (currentTabUrl.IndexOf(Constants.DashboardUrl, StringComparison.Ordinal) == -1) return info;

                #region ReadyToClaimTime

                var ReadyToClaimTime = Constants.DriverWait.Until(
                    ExpectedConditions.ElementToBeClickable(
                        By.XPath("//div[@class='vx-card mb-base']//h1")
                    )).Text;

                var ReadyToClaimButton = Constants.DriverWait.Until(
                    ExpectedConditions.PresenceOfAllElementsLocatedBy(
                        By.XPath("//div[@class='vx-card mb-base']//button")
                    )).Last().GetAttribute("disabled");
                if (ReadyToClaimButton == "disabled")
                {
                    info.ReadyToClaimActive = false;
                }
                else
                {
                    info.ReadyToClaimActive = true;
                }

                info.ReadyToClaimWaitingTime = ReadyToClaimTime;

                #endregion

                var ShortLinksCount = Constants.DriverWait.Until(
                    ExpectedConditions.ElementToBeClickable(
                        By.XPath("//div[@class='vs-content-sidebar v-nav-menu items-no-padding']//div[3]")
                    )).Text.Replace("Shortlinks", "").Trim();
                info.ShortLinksCount = string.IsNullOrEmpty(ShortLinksCount) ? "0" : ShortLinksCount;


                var AchievementsCount = Constants.DriverWait.Until(
                    ExpectedConditions.ElementToBeClickable(
                        By.XPath("//div[@class='vs-content-sidebar v-nav-menu items-no-padding']//div[4]")
                    )).Text.Replace("Achievements", "").Trim();
                info.AchievementsCount = string.IsNullOrEmpty(AchievementsCount) ? "0" : AchievementsCount;


                var PtcAdsCount = Constants.DriverWait.Until(
                    ExpectedConditions.ElementToBeClickable(
                        By.XPath("//div[@class='vs-content-sidebar v-nav-menu items-no-padding']//div[5]")
                    )).Text.Replace("Ptc Ads", "").Trim();

                info.PtcAdsCount = string.IsNullOrEmpty(PtcAdsCount) ? "0" : PtcAdsCount;

                return info;
            }
            catch
            {
                return info;
            }
        }

        public async Task<AdsInfoProperty> CurrentDetailsInfo()
        {
            var info = new AdsInfoProperty();
            var result = _apiService.HttpRequests(Constants.ApiDetailsUrl);

            try
            {
                dynamic json = JObject.Parse(result);

                // Profile Info
                info.Name = (string)json["result"]["name"];
                info.Email = (string)json["result"]["email"];

                // Balance
                info.Balance = (string)json["result"]["balance"];

                // Ready to claim
                var readyToClaimWaitingTime = (string)json["result"]["claim_time_remaining"];
                info.ReadyToClaimActive = readyToClaimWaitingTime.StartsWith("-");
                if (info.ReadyToClaimActive)
                {
                    info.ReadyToClaimWaitingTime = "Aktif";
                }
                else
                {
                    info.ReadyToClaimWaitingTime = readyToClaimWaitingTime;
                }

                // Shortlink
                info.ShortLinksCount = (string)json["result"]["sl_links_available"];

                // Archievements
                info.AchievementsCount = (string)json["result"]["achievements_available_to_claim"];

                // Ptc
                info.PtcAdsCount = (string)json["result"]["ptc_ads_available"];
            }
            catch
            {
                // ignore
            }

            return info;
        }

    }
}
