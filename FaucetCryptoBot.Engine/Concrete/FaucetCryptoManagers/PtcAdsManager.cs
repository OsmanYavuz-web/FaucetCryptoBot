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
    public class PtcAdsManager : AdsService, IStandardAdsService
    {
        public bool StartProcess()
        {
            try
            {
                // İlk sekmeyi seç
                Constants.Driver.SwitchTo().Window(Constants.Driver.WindowHandles.FirstOrDefault());

                // Servise bağlan
                Constants.BrowserService.Request(Constants.PtcAdsUrl);

                // Captcha uyarısı var mı
                if (Constants.BrowserService.PageSource().IndexOf(Constants.AdsCaptchaAlert, StringComparison.Ordinal) != -1)
                {
                    return false;
                }
                else
                {
                    // 0- İlk reklama tıkla
                    var elementFirstAds = Constants.DriverWait.Until(
                        ExpectedConditions.ElementToBeClickable(
                            By.XPath(Constants.PtcXpathFirstAdsClick)
                        ));
                    elementFirstAds.SendKeys("");
                    elementFirstAds.Click();
                    Thread.Sleep(2000);


                    // 1- Süreye kontrol et
                    AdsWaitingTime();

                    // 2- Visit Website butonuna tıkla
                    ClickVisitWebsite();


                    // 4- Açılan sayfada süreyi bekle
                    var resultWaitingTime2 = "";
                    do
                    {
                        try
                        {
                            var result = Constants.Driver.FindElement(By.XPath(Constants.PtcXpathWaitingTime)).Text;
                            if (result == "1")
                            {
                                resultWaitingTime2 = "0";
                            }
                        }
                        catch
                        {
                            //ignore
                        }

                    } while (resultWaitingTime2 != "0");
                    Thread.Sleep(Constants.DelayTime2);


                    // 5- Continue tıkla
                    var resultContinue = Constants.DriverWait.Until(
                        ExpectedConditions.ElementToBeClickable(
                            By.XPath(Constants.PtcXpathClickContinue)
                        ));
                    resultContinue.SendKeys("");
                    resultContinue.Click();
                    Thread.Sleep(Constants.DelayTime2);

                    FirstTabSelect(); // ilk sekmeyi seç diğerini kapat

                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
