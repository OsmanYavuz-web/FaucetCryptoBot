/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */

namespace FaucetCryptoBot.Engine.Entities
{
    public class AdsInfoProperty
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Balance { get; set; }
        public bool ReadyToClaimActive { get; set; }
        public string ReadyToClaimWaitingTime { get; set; }
        public string ShortLinksCount { get; set; }
        public string AchievementsCount { get; set; }
        public string PtcAdsCount { get; set; }
    }
}
