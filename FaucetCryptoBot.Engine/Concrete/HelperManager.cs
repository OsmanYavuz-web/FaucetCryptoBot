/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FaucetCryptoBot.Engine.Abstract;

namespace FaucetCryptoBot.Engine.Concrete
{

    public class HelperManager : IHelperService
    {

        public double ConvertToDouble(string s)
        {
            char systemSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];
            double result = 0;
            try
            {
                if (s != null)
                    if (!s.Contains(","))
                        result = double.Parse(s, CultureInfo.InvariantCulture);
                    else
                        result = Convert.ToDouble(s.Replace(".", systemSeparator.ToString()).Replace(",", systemSeparator.ToString()));
            }
            catch //(Exception e)
            {
                try
                {
                    result = Convert.ToDouble(s);
                }
                catch
                {
                    try
                    {
                        result = Convert.ToDouble(s.Replace(",", ";").Replace(".", ",").Replace(";", "."));
                    }
                    catch
                    {
                        throw new Exception("Wrong string-to-double format");
                    }
                }
            }
            return result;
        }


        public void SoundPlayer(string audioPath)
        {
            var player = new SoundPlayer
            {
                SoundLocation = audioPath
            };
            player.Play();
        }
    }



    public static class ForEachHelper
    {
        public sealed class Item<T>
        {
            public int Index { get; set; }
            public T Value { get; set; }
            public bool IsLast { get; set; }
        }

        public static IEnumerable<Item<T>> WithIndex<T>(IEnumerable<T> enumerable)
        {
            Item<T> item = null;
            foreach (T value in enumerable)
            {
                Item<T> next = new Item<T>();
                next.Index = 0;
                next.Value = value;
                next.IsLast = false;
                if (item != null)
                {
                    next.Index = item.Index + 1;
                    yield return item;
                }
                item = next;
            }
            if (item != null)
            {
                item.IsLast = true;
                yield return item;
            }
        }
    }

}
