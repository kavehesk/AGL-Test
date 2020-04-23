using PetOwner.Application.Models;
using System.Collections.Generic;

namespace PetOwner.Application.Queries.PetsGroupedByOwnerGender.ViewModels
{
    public class OwnerGenderWithPetsViewModel
    {
        public string Gender;
        public IReadOnlyCollection<string> PetNames;
    }
}