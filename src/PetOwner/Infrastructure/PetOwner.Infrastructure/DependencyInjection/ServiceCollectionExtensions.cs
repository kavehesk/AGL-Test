using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetOwner.Application.Services;
using PetOwner.Infrastructure.Services.PetOwnerServices;
using PetOwner.Infrastructure.Services.PetOwnerServices.Translators;
using PetOwner.Infrastructure.WebAccess;
using System.Reflection;

namespace PetOwner.Application.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        private static Assembly InfrastructureAssembly = Assembly.GetAssembly(typeof(PetOwnerService));
        public static IServiceCollection AddAllInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAllImplementations(InfrastructureAssembly, typeof(IService));


            services.AddSingleton<IOwnersTranslator, OwnersTranslator>();
            services.AddScoped(typeof(IWebClient<>), typeof(WebClient<>));
            services.AddHttpClient();

            services.Configure<PetOwnerServiceOptions>(configuration);

            return services;
        }
    }
}
