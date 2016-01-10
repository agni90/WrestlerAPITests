using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
