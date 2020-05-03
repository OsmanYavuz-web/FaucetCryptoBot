/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Cookie = OpenQA.Selenium.Cookie;

namespace FaucetCryptoBot.Engine.Abstract
{
    public interface IBrowserService
    {
        void Request(string url);
        void LoadSetting();
        void BrowserQuit();
        string PageSource();
        ReadOnlyCollection<Cookie> GetCookie();
    }
}
