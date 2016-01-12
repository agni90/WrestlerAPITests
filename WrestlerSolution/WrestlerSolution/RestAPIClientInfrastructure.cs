using System;
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

        public RestAPIClientInfrastructure(string login, string pass)
        {
            _client = new RestClient(_baseURL) { Authenticator = new HttpBasicAuthenticator(login, pass) };
            var cookie = GetCookiePostMethod();
            _sessionCookieValue = cookie;

        }

        public RestAPIClientInfrastructure()
        {
            _client = new RestClient(_baseURL);
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

        public string DeleteMethod(string requestUrl)
        {
            if (_client == null) throw new Exception("client is null");

            var request = new RestRequest(requestUrl, Method.DELETE);
            request.AddCookie(_sessionCookieId, _sessionCookieValue);
            IRestResponse response = _client.Execute(request);
            return response.Content;
        }

        public string UpdateMethod(string requestUrl, string jsonToSend)
        {
            var request = new RestRequest(requestUrl, Method.POST);
            request.AddCookie(_sessionCookieId, _sessionCookieValue);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            IRestResponse response = _client.Execute(request);
            return response.Content;
        }

        private string GetCookiePostMethod()
        {
            string requestUrl = "php/login.php";
            string jsonToSend = "{ \"username\":\"auto\",\"password\":\"test\"}";
            var request = new RestRequest(requestUrl, Method.POST);
            request.AddParameter("application/json; charset=utf-8", jsonToSend, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            IRestResponse response = _client.Execute(request);
            return response.Cookies[0].Value;
        }
    }
}
