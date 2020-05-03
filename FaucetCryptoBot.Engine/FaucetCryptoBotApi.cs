/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using System.Threading.Tasks;
using FaucetCryptoBot.Engine.Abstract;
using FaucetCryptoBot.Engine.Abstract.FaucetCryptoServices;
using FaucetCryptoBot.Engine.Concrete;
using FaucetCryptoBot.Engine.Concrete.FaucetCryptoManagers;
using FaucetCryptoBot.Engine.Entities;
using reCAPTCHA.Resolver.Core;

namespace FaucetCryptoBot.Engine
{
    public class FaucetCryptoBotApi
    {
        public IHelperService HelperService = new HelperManager();

        private readonly IStandardAdsService _readyToClaimService = new ReadyToClaimManager();
        private readonly IStandardAdsService _shortLinksService = new ShortLinksManager();
        private readonly IStandardAdsService _ptcAdsService = new PtcAdsManager();

        /// <summary>
        /// FaucetCryptoBot Build
        /// </summary>
        /// <param name="apiKey">IBM Speech to Text api key</param>
        /// <param name="serviceUrl">IBM Speech to Text service url</param>
        public FaucetCryptoBotApi(string apiKey, string serviceUrl)
        {
            Constants.LoginService.ResolverService = new ResolverService(
                apiKey,
                serviceUrl
            );
        }


        /// <summary>
        /// Siteye giriş yap
        /// </summary>
        /// <param name="loginProperty">Kullanıcı bilgileri</param>
        /// <returns></returns>
        public Task<Response> Login(LoginProperty loginProperty)
        {
            return Task.Run(() =>
            {
                Constants.BrowserService.LoadSetting();
                return Constants.LoginService.Login(loginProperty);
            });
        }

        /// <summary>
        /// Tarayıcıyı kapatma
        /// </summary>
        public void Logout()
        {
            Constants.BrowserService.BrowserQuit();
        }

        /// <summary>
        /// Kullanıcının detaylı bilgisi
        /// </summary>
        /// <returns></returns>
        public async Task<AdsInfoProperty> CurrentDetailsInfo()
        {
            return await Constants.LoginService.CurrentDetailsInfo();
        }

        /// <summary>
        /// Api token bilgilerini aktar
        /// </summary>
        public void SetApiToken(string authorization)
        {
            Constants.LoginService.SetApiToken(authorization);
        }


        /// <summary>
        /// Ready to Claim Reklam Servisi
        /// </summary>
        /// <returns></returns>
        public bool ReadyToClaimProcess()
        {
            return _readyToClaimService.StartProcess();
        }


        /// <summary>
        /// ShortLinks Reklam Servisi
        /// </summary>
        /// <returns></returns>
        public bool ShortLinksProcess()
        {
            return _shortLinksService.StartProcess();
        }

        /// <summary>
        /// PtcAds Reklam Servisi
        /// </summary>
        /// <returns></returns>
        public bool PtcAdsProcess()
        {
            return _ptcAdsService.StartProcess();
        }



    }
}
