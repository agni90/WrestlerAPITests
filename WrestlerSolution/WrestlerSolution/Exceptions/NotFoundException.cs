using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WrestlerSolution.Exceptions
{
    public class NotFoundException : HttpResponseException
    {
        public NotFoundException(HttpStatusCode statusCode) : base(statusCode)
        {
           
        }
        public NotFoundException(HttpResponseMessage response) : base (response)
        {
       
        }
    }
}
