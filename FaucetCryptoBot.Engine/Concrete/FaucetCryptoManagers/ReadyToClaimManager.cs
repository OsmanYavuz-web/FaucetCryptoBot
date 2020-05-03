/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using System;
using System.Linq;
using FaucetCryptoBot.Engine.Abstract;
using FaucetCryptoBot.Engine.Abstract.FaucetCryptoServices;

namespace FaucetCryptoBot.Engine.Concrete.FaucetCryptoManagers
{
    public class ReadyToClaimManager : AdsService, IStandardAdsService
    {
        public bool StartProcess()
        {
            try
            {
                // İlk sekmeyi seç
                Constants.Driver.SwitchTo().Window(Constants.Driver.WindowHandles.FirstOrDefault());

                // Servise bağlan
                Constants.BrowserService.Request(Constants.ReadyToClaimUrl);

                // Captcha uyarısı var mı
                if (Constants.BrowserService.PageSource().IndexOf(Constants.AdsCaptchaAlert, StringComparison.Ordinal) != -1)
                {
                    return false;
                }
                else
                {

                    // 1- Süreye kontrol et
                    AdsWaitingTime();

                    // 2- Visit Website butonuna tıkla
                    ClickVisitWebsite();

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
