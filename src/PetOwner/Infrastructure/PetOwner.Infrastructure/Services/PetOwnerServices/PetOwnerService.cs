using PetOwner.Application.ReadModels;
using PetOwner.Application.Services;
using PetOwner.Infrastructure.Services.PetOwnerServices.Translators;
using PetOwner.Infrastructure.WebAccess;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.Extensions.Options;

namespace PetOwner.Infrastructure.Services.PetOwnerServices
{
    class PetOwnerService : IPetOwnerService
    {
        private readonly IOwnersTranslator _ownersTranslator;
        private readonly IWebClient<IReadOnlyCollection<Models.Owner>> _webClient;
        private readonly PetOwnerServiceOptions _options;

        public PetOwnerService(
            IOwnersTranslator ownersTranslator,
            IWebClient<IReadOnlyCollection<Models.Owner>> webClient,
            IOptionsMonitor<PetOwnerServiceOptions> options)
        {
            _ownersTranslator = ownersTranslator;
            _webClient = webClient;
            _options = options.CurrentValue;
        }

        public async Task<IReadOnlyCollection<Owner>> GetAllOwners()
        {
            var owners = await _webClient.Get(_options.AglPetOwnerEndpoint);
            return owners.Select(_ownersTranslator.Translate).ToList();
        }
    }
}
