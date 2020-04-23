using Microsoft.Extensions.DependencyInjection;
using PetOwner.Application.Services;
using PetOwner.Infrastructure.Services;
using PetOwner.Infrastructure.WebAccess;
using System.Net.Http;
using System.Reflection;

namespace PetOwner.Application.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAllInfrastructureServices(this IServiceCollection services)
        {
            var interfaceType = typeof(IService);
            var infrastructureAssembly = Assembly.GetAssembly(typeof(PetOwnerService));

            services.AddAllImplementations(infrastructureAssembly, interfaceType);
            services.AddScoped(typeof(IWebClient<>), typeof(WebClient<>));
            services.AddSingleton(new HttpClient());
            return services;
        }
    }
}
