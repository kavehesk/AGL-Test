using PetOwner.Application.Models;
using PetOwner.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetOwner.Infrastructure.Services
{
    class PetOwnerService : IPetOwnerService
    {
        public Task<IReadOnlyCollection<OwnerPet>> GetAllOwnersAndTheirPets()
        {
            throw new System.NotImplementedException();
        }
    }
}
