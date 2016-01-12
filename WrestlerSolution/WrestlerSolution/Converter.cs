using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrestlerSolution.Models;
using Newtonsoft.Json;

namespace WrestlerSolution
{
    public static class Converter
    {
        public static SimpleWrestler JsonResponseToSimpleWrestler(string responseContent)
        {
            SimpleWrestler simpleWrestler = JsonConvert.DeserializeObject<SimpleWrestler>(responseContent);
            return simpleWrestler;
        }

        public static Wrestler JsonResponseToWrestler(string responseContent)
        {
            Wrestler simpleWrestler = JsonConvert.DeserializeObject<Wrestler>(responseContent);
            return simpleWrestler;
        }

        public static string WrestlerToJsonRequest(Wrestler wrestler)
        {
            string json = JsonConvert.SerializeObject(wrestler);
            return json;
        }

        public static string SimpleWrestlerToJsonRequest(SimpleWrestler wrestler)
        {
            string json = JsonConvert.SerializeObject(wrestler);
            return json;
        }
    }
}
