/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
namespace FaucetCryptoBot.Engine.Abstract
{
    public interface IApiService
    {
        string Authorization { get; set; }
        string HttpRequests(string url);
    }
}
