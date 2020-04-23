using Microsoft.Extensions.DependencyInjection;
using PetOwner.Application.Queries;
using System;
using System.Linq;
using System.Reflection;

namespace PetOwner.Application.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAllImplementations(this IServiceCollection service, Assembly assembly, Type interfaceType)
        {
            var implementations = assembly.GetTypes()
                .Where(x => !x.IsAbstract && x.IsClass
                && interfaceType.IsAssignableFrom(x));
            foreach (var imp in implementations)
            {
                var childInterface = imp.GetInterfaces()
                    .Where(i => !i.IsGenericType && interfaceType != i
                            && interfaceType.IsAssignableFrom(i))
                    .SingleOrDefault();
                if (childInterface != null)
                {
                    service.AddScoped(childInterface, imp);
                }
            }
            return service;
        }

        public static IServiceCollection AddAllQueries(this IServiceCollection service)
        {
            var interfaceType = typeof(IQuery);
            return service.AddAllImplementations(Assembly.GetAssembly(interfaceType), interfaceType);
        }
    }
}
