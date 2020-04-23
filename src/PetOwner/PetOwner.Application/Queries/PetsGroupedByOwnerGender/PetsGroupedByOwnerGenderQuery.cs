using PetOwner.Application.Models;
using PetOwner.Application.Queries.Pets.ViewModels;
using PetOwner.Application.Repositories;
using System.Threading.Tasks;

namespace PetOwner.Application.Queries.Pets
{
    class PetsGroupedByOwnerGenderQuery : IPetsGroupByOwnerGenderQuery
    {
        private readonly IPetOwnerService _petOwnerService;
        public async Task<PetsGroupedByOwnerGenderViewModel> Run(PetType petType)
        {
            var pownersAndTheirPets = _petOwnerService.GetAllOwnersAndTheirPets();
            return null;
        }
    }
}
