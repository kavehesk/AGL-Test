using System.Collections.Generic;

namespace PetOwner.Application.ReadModels
{
    public class Owner
    {
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public byte Age { get; set; }

        public IReadOnlyCollection<Pet> Pets { get; set; }
    }
}
