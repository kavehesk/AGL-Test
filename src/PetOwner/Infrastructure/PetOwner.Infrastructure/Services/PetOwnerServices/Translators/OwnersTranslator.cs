using PetOwner.Application.ReadModels;
using PetOwner.Infrastructure.Enums;
using System.Linq;

namespace PetOwner.Infrastructure.Services.PetOwnerServices.Translators
{
    class OwnersTranslator : IOwnersTranslator
    {
        public Owner Translate(Models.Owner from)
        {
            return new Owner
            {
                Age = (byte)from.Age,
                Name = from.Name,
                Gender = from.Gender.Parse<Gender>(),
                Pets = from.Pets.Select(x => new Pet
                {
                    Name = x.Name,
                    Type = x.Type.Parse<PetType>()
                }).ToList()
            };
        }
    }
}
