using PetOwner.Application.Models;
using System.Collections.Generic;

namespace PetOwner.Application.Queries.PetsGroupedByOwnerGender.ViewModels
{
    public class PetOwnerGenderViewModel
    {
        public Gender Gender;
        public IReadOnlyCollection<string> PetNames;
    }
}