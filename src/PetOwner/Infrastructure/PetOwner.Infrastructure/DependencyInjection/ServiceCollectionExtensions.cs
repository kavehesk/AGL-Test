using Microsoft.Extensions.DependencyInjection;
using PetOwner.Application.Services;
using PetOwner.Infrastructure.Services;
using System.Reflection;

namespace PetOwner.Application.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAllServices(this IServiceCollection service)
        {
            var interfaceType = typeof(IService);
            return service.AddAllImplementations(Assembly.GetAssembly(typeof(PetOwnerService)), interfaceType);
        }
    }
}
