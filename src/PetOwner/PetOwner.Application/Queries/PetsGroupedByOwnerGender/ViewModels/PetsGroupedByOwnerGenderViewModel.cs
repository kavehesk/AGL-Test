using System.Collections.Generic;

namespace PetOwner.Application.Queries.Pets.ViewModels
{
    public class PetsGroupedByOwnerGenderViewModel
    {
        public IReadOnlyCollection<PetOwnerGenderViewModel> Genders;
    }
}