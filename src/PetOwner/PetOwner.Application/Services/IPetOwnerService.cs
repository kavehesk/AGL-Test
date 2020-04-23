using PetOwner.Application.Models;
using System.Collections.Generic;

namespace PetOwner.Application.Repositories
{
    public interface IPetOwnerService
    {
        IReadOnlyCollection<OwnersAndTheirPets> GetAllOwnersAndTheirPets();
    }
}
