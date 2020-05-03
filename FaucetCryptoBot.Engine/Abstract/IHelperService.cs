/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaucetCryptoBot.Engine.Abstract
{
    public interface IHelperService
    {
        double ConvertToDouble(string s);
        void SoundPlayer(string audioPath);
    }
}
