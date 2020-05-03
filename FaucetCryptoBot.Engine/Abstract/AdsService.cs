/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using System;
using System.Linq;
using System.Threading;
using FaucetCryptoBot.Engine.Concrete;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace FaucetCryptoBot.Engine.Abstract
{
    public abstract class AdsService
    {
        /// <summary>
        /// Gereksiz sekmeleri kapatır ve ilk sekmeyi seçer
        /// </summary>
        public static void FirstTabSelect()
        {
            try
            {
                var windowHandles = Constants.Driver.WindowHandles;

                foreach (var windowHandle in ForEachHelper.WithIndex(windowHandles))
                {
                    if (windowHandle.Index == 0) continue;
                    var selectTab = Constants.Driver.SwitchTo().Window(windowHandle.Value);
                    selectTab.Close();
                }

                // İlk sekmeyi seç
                var selectFirstTab = Constants.Driver.SwitchTo().Window(Constants.Driver.WindowHandles.FirstOrDefault());
                if (selectFirstTab.Url.IndexOf(Constants.BaseUrl, StringComparison.Ordinal) == -1)
                {
                    // Home Url aç
                    Constants.BrowserService.Request(Constants.HomeUrl);
                }
            }
            catch
            {
                // ignore
            }
        }


        /// <summary>
        /// 1- İlk Süreyi Kontrol Et
        /// Reklamda çıkan süreyi bekle
        /// </summary>
        public static void AdsWaitingTime()
        {
            // 1- Süreye kontrol et
            var resultWaitingTime = "";
            do
            {
                var result = Constants.DriverWait.Until(
                    ExpectedConditions.PresenceOfAllElementsLocatedBy(
                        By.XPath(Constants.AdsXpathGetWaitingTime)
                    )).FirstOrDefault().Text;
                if (string.IsNullOrEmpty(result))
                {
                    resultWaitingTime = "0";
                }
            } while (resultWaitingTime != "0");
            Thread.Sleep(Constants.DelayTime2);
        }


        /// <summary>
        /// 2- Visit Website butonuna tıklar
        /// </summary>
        public static void ClickVisitWebsite()
        {
            // 2- Visit Website butonuna tıkla
            var elementVisitWebSite = Constants.DriverWait.Until(
                ExpectedConditions.PresenceOfAllElementsLocatedBy(
                    By.XPath(Constants.AdsXpathClick)
                )).LastOrDefault();
            elementVisitWebSite.SendKeys("");
            elementVisitWebSite.Click();
            Thread.Sleep(Constants.DelayTime2);
        }

    }
}
