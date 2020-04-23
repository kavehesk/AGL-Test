using PetOwner.Application.Queries.PetsGroupedByOwnerGender.ViewModels;
using PetOwner.Application.ReadModels;
using System.Threading.Tasks;

namespace PetOwner.Application.Queries.PetsGroupedByOwnerGender
{
    public interface IPetsGroupedByOwnerGenderQuery : IQuery
    {
        Task<PetsGroupedByOwnerGenderViewModel> Run(PetType petType);
    }
}
