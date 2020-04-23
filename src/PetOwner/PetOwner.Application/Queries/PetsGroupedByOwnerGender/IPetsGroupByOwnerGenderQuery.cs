using PetOwner.Application.Models;
using PetOwner.Application.Queries.Pets.ViewModels;
using System.Threading.Tasks;

namespace PetOwner.Application.Queries.Pets
{
    public interface IPetsGroupByOwnerGenderQuery : IQuery
    {
        Task<PetsGroupedByOwnerGenderViewModel> Run(PetType petType);
    }
}
