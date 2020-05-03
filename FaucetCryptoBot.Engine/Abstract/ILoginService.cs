/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using System;
using System.Threading.Tasks;
using FaucetCryptoBot.Engine.Entities;
using reCAPTCHA.Resolver.Core;

namespace FaucetCryptoBot.Engine.Abstract
{
    public interface ILoginService
    {
        void SetApiToken(string authorization);

        ResolverService ResolverService { get; set; }
        Task<Response> Login(LoginProperty loginProperty);
        Task<AdsInfoProperty> CurrentAdsInfo();

        Task<AdsInfoProperty> CurrentDetailsInfo();
    }

}
