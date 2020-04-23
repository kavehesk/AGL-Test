using System.Collections.Generic;

namespace PetOwner.Application.Models
{
    public class Owner
    {
        public string Name { get;  protected set; }

        public Gender Gender { get; protected set; }

        public long Age { get; protected set; }

        public IReadOnlyCollection<Pet> Pets { get; protected set; }
    }
}
