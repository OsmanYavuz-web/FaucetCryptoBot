/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using System;
using System.Linq;
using System.Threading;
using FaucetCryptoBot.Engine.Abstract;
using FaucetCryptoBot.Engine.Abstract.FaucetCryptoServices;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace FaucetCryptoBot.Engine.Concrete.FaucetCryptoManagers
{
    class ShortLinksManager: AdsService, IStandardAdsService
    {
        public bool StartProcess()
        {
            try
            {
                // İlk sekmeyi seç
                Constants.Driver.SwitchTo().Window(Constants.Driver.WindowHandles.FirstOrDefault());

                // Servise bağlan
                Constants.BrowserService.Request(Constants.ShortLinksUrl);

                // 1- Reklamları Listele
                var adsList = Constants.DriverWait.Until(
                    ExpectedConditions.PresenceOfAllElementsLocatedBy(
                        By.XPath(Constants.ShortLinksXpathAdsList)
                    ));

                // Reklamları döndür
                foreach (var ads in ForEachHelper.WithIndex(adsList))
                {
                    var adsIndex = ads.Index + 1;
                    var adsStatus = ads.Value.FindElement(By.XPath(string.Format(Constants.ShortLinksXpathAdsStatus, adsIndex)));
                    var adsButtonElement = ads.Value.FindElement(By.XPath(string.Format(Constants.ShortLinksXpathAdsClick, adsIndex)));

                    if (adsStatus.Text != "100%" & adsIndex <= 3)
                    {
                        // Captcha uyarısı var mı
                        if (Constants.BrowserService.PageSource()
                                .IndexOf(Constants.AdsCaptchaAlert, StringComparison.Ordinal) != -1)
                        {
                            return false;
                        }
                        else
                        {
                            // 1- İlk reklama tıkla
                            var firstAds = Constants.DriverWait.Until(
                                ExpectedConditions.ElementToBeClickable(
                                    adsButtonElement
                                ));
                            firstAds.SendKeys("");
                            firstAds.Click();


                            // 2- Süreye kontrol et
                            AdsWaitingTime();

                            // 3- Visit Website butonuna tıkla
                            ClickVisitWebsite();


                            // 4- Step 1/2 - "Show Timer / Click Here" tıkla
                            ClickShowTimer();


                            // Burada yeni bir pencere açılıyor ve arkada düşüyor
                            // İlk sekmeye focuslanmak için
                            Constants.Driver.SwitchTo().Window(Constants.Driver.WindowHandles.FirstOrDefault());


                            // 5- Step 1/2 - "Kalan süre"
                            GetTimeWaiting();


                            //6 - Step 1 / 2 - "Continue" tıkla
                            ClickContinue();


                            // 7- Step 1/2 - "Show Timer / Click Here" tıkla
                            ClickShowTimer();


                            // Burada yeni bir pencere açılıyor ve arkada düşüyor
                            // İlk sekmeye focuslanmak için
                            Constants.Driver.SwitchTo().Window(Constants.Driver.WindowHandles.FirstOrDefault());


                            // 8- Step 2/2 - "Kalan süre"
                            GetTimeWaiting();


                            //9 - Step 2 / 2 - "Continue" tıkla
                            ClickContinue();
                        }
                    }

                    FirstTabSelect(); // ilk sekmeyi seç diğerini kapat
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private protected static void ClickContinue()
        {
            var elementContinue1 = Constants.DriverWait.Until(
                ExpectedConditions.ElementToBeClickable(
                    By.XPath(Constants.ShortLinksXpathClickContinue)
                ));
            elementContinue1.SendKeys("");
            elementContinue1.Click();
            Thread.Sleep(Constants.DelayTime2);
        }

        private protected static void GetTimeWaiting()
        {
            var resultShowTimer1 = "";
            do
            {
                var result = Constants.DriverWait.Until(
                    ExpectedConditions.ElementToBeClickable(
                        By.XPath(Constants.ShortLinksXpathTime)
                    )).Text;
                if (result == "0")
                {
                    resultShowTimer1 = "0";
                }
            } while (resultShowTimer1 != "0");

            Thread.Sleep(Constants.DelayTime2);
        }

        private protected static void ClickShowTimer()
        {
            var elementShowTimer1 = Constants.DriverWait.Until(
                ExpectedConditions.ElementToBeClickable(
                    By.XPath(Constants.ShortLinksXpathClickHere)
                ));
            elementShowTimer1.SendKeys("");
            elementShowTimer1.Click();
            Thread.Sleep(Constants.DelayTime2);
        }


    }
}
