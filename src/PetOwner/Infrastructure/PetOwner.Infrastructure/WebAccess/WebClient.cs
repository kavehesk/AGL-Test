using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace PetOwner.Infrastructure.WebAccess
{
    class WebClient<T> : IWebClient<T>
    {
        private readonly IHttpClientFactory _clientFactory;

        public WebClient(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> Get(string serviceEndpointUrl)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, serviceEndpointUrl);

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseString);
            }
            throw new WebApiException(response, response.Content);
        }
    }
}
