/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
namespace FaucetCryptoBot.Engine.Entities
{
    public enum ResponseStatus
    {
        Success,
        Error,
        Waiting
    }
    public class Response : IEntity
    {
        public ResponseStatus Code { get; set; }
        public string Message { get; set; }
        public object Object { get; set; }
    }
}
