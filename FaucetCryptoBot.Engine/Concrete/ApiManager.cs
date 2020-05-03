/*
 *
 * Osman Yavuz
 * omnyvz.yazilim@gmail.com
 *
 */
using FaucetCryptoBot.Engine.Abstract;
using RestSharp;

namespace FaucetCryptoBot.Engine.Concrete
{
    public class ApiManager : IApiService
    {
        public string Authorization { get; set; }

        public string HttpRequests(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest
            {
                Method = Method.POST
            };

            request.AddHeader("content-type", "application/json;charset=UTF-8");
            request.AddHeader("Authorization", Authorization);

            request.RequestFormat = DataFormat.Json;

            var response = client.Execute(request);
            var content = response.Content;

            return content;
        }

    }
}
