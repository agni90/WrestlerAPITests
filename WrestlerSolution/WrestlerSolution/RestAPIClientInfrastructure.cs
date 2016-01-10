using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace WrestlerSolution
{
    public class RestAPIClientInfrastructure
    {
        private readonly RestClient _client;
        private readonly string _baseURL = @"http://streamtv.net.ua/base";
        private readonly string _sessionCookieValue;
        private readonly string _sessionCookieId = "PHPSESSID";

        public RestAPIClientInfrastructure(string login, string pass, string SessionCookie)
        {
            _client = new RestClient(_baseURL) { Authenticator = new HttpBasicAuthenticator(login, pass) };
            _sessionCookieValue = SessionCookie;
        }

        public string GetMethod(string requestUrl)
        {
            if (_client == null) throw new Exception("_client is null");
            //todo add exception handling

            var request = new RestRequest(requestUrl, Method.GET);
            request.AddCookie(_sessionCookieId, _sessionCookieValue);
            IRestResponse response = _client.Execute(request);
            return response.Content;
        }

        public string PostMethod(string requestUrl, string jsonToSend)
        {
            var request = new RestRequest(requestUrl, Method.POST);
            request.AddCookie(_sessionCookieId, _sessionCookieValue);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            IRestResponse response = _client.Execute(request);
            return response.Content;
        }
    }
}
