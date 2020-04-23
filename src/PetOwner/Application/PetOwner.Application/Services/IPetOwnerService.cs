using PetOwner.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetOwner.Application.Services
{
    public interface IPetOwnerService : IService
    {
        Task<IReadOnlyCollection<OwnerPet>> GetAllOwnersAndTheirPets();
    }
}
