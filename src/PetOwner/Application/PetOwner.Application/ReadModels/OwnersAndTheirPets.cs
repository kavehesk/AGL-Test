using System.Collections.Generic;

namespace PetOwner.Application.Models
{
    public class OwnersAndTheirPets
    {
        public Owner Owner { get; set; }
        public IReadOnlyCollection<Pet> Pets { get; set; }
    }
}