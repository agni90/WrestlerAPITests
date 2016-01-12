using WrestlerSolution.Models.Requests;
using WrestlerSolution.Models.Responses;
using WrestlerSolution.Exceptions;
using System.Net;
using Newtonsoft.Json;

namespace WrestlerSolution
{
    public class WrestlerClient
    {
        RestAPIClientInfrastructure _client;

        public WrestlerClient(string login, string pass)
        {
            _client = new RestAPIClientInfrastructure(login, pass);
        }

        public string ReadWrestlerById(int wreslerId)
        {
            string url = string.Format("php/wrestler/read.php?id={0}", wreslerId);
            return _client.GetMethod(url);
        }

        public CreateWrestlerResponse CreateWrestler(CreateWrestlerRequest wrestlerRequest)
        {
            string url = "php/wrestler/create.php";
            var wrestlerJson = Converter.SimpleWrestlerToJsonRequest(wrestlerRequest.Wrestler);
            var response = _client.PostMethod(url, wrestlerJson);
            if (response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<CreateWrestlerResponse>(response.Content);
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new UserCreationFailedException(response.ErrorMessage);
            }
            return null;
        }

        public DeleteWrestlerResponse DeleteWrestler(DeleteWrestlerRequest request)
        {
            string url = string.Format("php/wrestler/delete.php?id={0}", request.Id);
            var response = _client.DeleteMethod(url);
            if (response.StatusCode == HttpStatusCode.OK)
                return JsonConvert.DeserializeObject<DeleteWrestlerResponse>(response.Content);
            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new NotFoundException(response.StatusCode);
            }
            return null;
        }

        public string UpdateWrestlerAccount(string wrestlerJson)
        {
            string url = "php/wrestler/update.php";
            return _client.UpdateMethod(url, wrestlerJson);
        }
    }
}
