using PetOwner.Application.Models;
using PetOwner.Application.Queries.PetsGroupedByOwnerGender.ViewModels;
using PetOwner.Application.Repositories;
using System.Threading.Tasks;
using System.Linq;

namespace PetOwner.Application.Queries.PetsGroupedByOwnerGender
{
    class PetsGroupedByOwnerGenderQuery : IPetsGroupByOwnerGenderQuery
    {
        private readonly IPetOwnerService _petOwnerService;

        public PetsGroupedByOwnerGenderQuery(IPetOwnerService petOwnerService)
        {
            _petOwnerService = petOwnerService;
        }

        public async Task<PetsGroupedByOwnerGenderViewModel> Run(PetType petType)
        {
            var ownersAndTheirPets = await _petOwnerService.GetAllOwnersAndTheirPets();

            var catOwnerGenderGroups =
                from op in ownersAndTheirPets
                from p in op.Pets
                where p.Type == PetType.Cat
                group op by op.Owner.Gender;


            return null;
        }
    }
}
