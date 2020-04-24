using System.Collections.Generic;

namespace PetOwner.Application.Queries.PetsGroupedByOwnerGender.ViewModels
{
    public class PetsGroupedByOwnerGenderViewModel
    {
        public IReadOnlyCollection<OwnerGenderWithPetsViewModel> Genders;
    }
}