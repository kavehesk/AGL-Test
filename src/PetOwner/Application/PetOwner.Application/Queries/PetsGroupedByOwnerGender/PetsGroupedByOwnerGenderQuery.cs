using PetOwner.Application.Queries.PetsGroupedByOwnerGender.ViewModels;
using System.Threading.Tasks;
using System.Linq;
using PetOwner.Application.Services;
using PetOwner.Application.ReadModels;

namespace PetOwner.Application.Queries.PetsGroupedByOwnerGender
{
    class PetsGroupedByOwnerGenderQuery : IPetsGroupedByOwnerGenderQuery
    {
        private readonly IPetOwnerService _petOwnerService;

        public PetsGroupedByOwnerGenderQuery(IPetOwnerService petOwnerService)
        {
            _petOwnerService = petOwnerService;
        }

        public async Task<PetsGroupedByOwnerGenderViewModel> Run(PetType petType)
        {
            var owners = await _petOwnerService.GetAllOwners();

            var ownerGenderAndPets=
                from op in owners
                from p in op.Pets
                where p.Type == petType
                select new { op.Gender, p.Name };

            var ownerGenderWithPetsViewModels =
                (from ogap in ownerGenderAndPets
                group ogap by ogap.Gender into g
                select new OwnerGenderWithPetsViewModel
                {
                    Gender = g.Key.ToString(),
                    PetNames = g.Select(x => x.Name).OrderBy(x => x).ToList()
                }).ToList();

            return new PetsGroupedByOwnerGenderViewModel
            {
                Genders = ownerGenderWithPetsViewModels
            };
        }
    }
}
