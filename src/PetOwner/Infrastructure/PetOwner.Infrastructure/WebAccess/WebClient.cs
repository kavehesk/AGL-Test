using System.Net.Http;
using System.Threading.Tasks;

namespace PetOwner.Infrastructure.WebAccess
{
    class WebClient<T> : IWebClient<T>
    {
        private readonly HttpClient _httpClient ;

        public WebClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> Get(string serviceEndpointUrl)
        {
            return default(T);
        }
    }
}
