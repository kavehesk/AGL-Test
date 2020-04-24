using Microsoft.Extensions.DependencyInjection;
using PetOwner.Application.Queries;
using System;
using System.Linq;
using System.Reflection;

namespace PetOwner.Application.DependencyInjections
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Finds all the implementation of the requested interface in the target assembly and add them to the service collection
        /// </summary>
        /// <param name="service"></param>
        /// <param name="assembly"></param>
        /// <param name="interfaceType"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Adds all the application layer services to the service collection
        /// </summary>
        /// <param name="service"></param>
        /// <returns></returns>
        public static IServiceCollection AddAllApplicationServices(this IServiceCollection service)
        {
            var interfaceType = typeof(IQuery);
            return service.AddAllImplementations(Assembly.GetAssembly(interfaceType), interfaceType);
        }
    }
}
