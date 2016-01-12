using System.Net;
using System.Web.Http;

namespace WrestlerSolution.Exceptions
{
    public class NotFoundException
    {
        public void Throw404WhenUserNotFound()
        {
            HttpStatusCode wrestlerStatusCode = new HttpStatusCode();

            if (wrestlerStatusCode == HttpStatusCode.NotFound)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }
    }
}
