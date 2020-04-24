using PetOwner.Application.ReadModels;
using PetOwner.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PetOwner.Infrastructure.Services.PetOwnerServices.Translators
{
    class OwnersTranslator : IOwnersTranslator
    {
        public Application.ReadModels.Owner Translate(Models.Owner from)
        {
            return new Application.ReadModels.Owner
            {
                Age = (byte)from.Age,
                Name = from.Name,
                Gender = from.Gender.Parse<Gender>(),
                Pets = GetPetListOrEmptyListIfNull(from.Pets)
            };
        }

        private IReadOnlyCollection<Pet> GetPetListOrEmptyListIfNull(IEnumerable<Models.Pet> pets)
        {
            return
                pets?.Select(x => new Pet
                {
                    Name = x.Name,
                    Type = x.Type.Parse<PetType>()
                }).ToList() 
                ?? new List<Pet>();
        }
    }
}
