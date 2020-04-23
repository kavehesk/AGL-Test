using System.Threading.Tasks;

namespace PetOwner.Infrastructure.WebAccess
{
    interface IWebClient<T>
    {
        Task<T> Get(string serviceEndpointUrl);
    }
}
