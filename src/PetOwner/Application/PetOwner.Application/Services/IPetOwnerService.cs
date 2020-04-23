using PetOwner.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetOwner.Application.Repositories
{
    public interface IPetOwnerService
    {
        Task<IReadOnlyCollection<OwnersAndTheirPets>> GetAllOwnersAndTheirPets();
    }
}
