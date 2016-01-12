
using System.Runtime.Remoting.Metadata.W3cXsd2001;

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

        public string CreateWrestler(string wrestlerJson)
        {
            string url= "php/wrestler/create.php";
            return _client.PostMethod(url, wrestlerJson);
        }

        public string DeleteWrestler(int wrestlerId)
        {
            string url = string.Format("php/wrestler/delete.php?{0}", wrestlerId);
            return _client.DeleteMethod(url);
        }

        public string UpdateWrestlerAccount(string wrestlerJson)
        {
            string url = "php/wrestler/update.php";
            return _client.UpdateMethod(url, wrestlerJson);
        }
    }
}
