using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetOwner.Application.Services;
using PetOwner.Infrastructure.Services;
using PetOwner.Infrastructure.Services.PetOwnerServices;
using PetOwner.Infrastructure.WebAccess;
using System.Net.Http;
using System.Reflection;

namespace PetOwner.Application.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAllInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var infrastructureAssembly = Assembly.GetAssembly(typeof(PetOwnerService));

            services.AddAllImplementations(infrastructureAssembly, typeof(IService));
            services.AddAllImplementations(infrastructureAssembly, typeof(ITranslator<,>));

            services.AddScoped(typeof(IWebClient<>), typeof(WebClient<>));
            services.AddSingleton(new HttpClient());

            services.AddHttpClient();

            services.Configure<PetOwnerServiceOptions>(configuration);

            return services;
        }
    }
}
