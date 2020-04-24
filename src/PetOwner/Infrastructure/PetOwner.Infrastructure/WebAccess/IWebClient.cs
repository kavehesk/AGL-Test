using System.Threading.Tasks;

namespace PetOwner.Infrastructure.WebAccess
{
    /// <summary>
    /// An interface to do web communication for specific type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IWebClient<T>
    {
        Task<T> Get(string serviceEndpointUrl);
    }
}
