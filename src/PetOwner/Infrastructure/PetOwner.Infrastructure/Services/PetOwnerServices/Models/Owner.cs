using System.Collections.Generic;

namespace PetOwner.Infrastructure.Services.PetOwnerServices.Models
{
    class Owner
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public long Age { get; set; }

        public IEnumerable<Pet> Pets { get; set; }
    }
}
