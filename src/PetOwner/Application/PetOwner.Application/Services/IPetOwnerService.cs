using PetOwner.Application.ReadModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetOwner.Application.Services
{
    public interface IPetOwnerService : IService
    {
        Task<IReadOnlyCollection<Owner>> GetAllOwners();
    }
}
