using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using PetOwner.Application.DependencyInjection;
using System;

namespace PetOwner.Application.Test
{
    class TestBase
    {
        protected IServiceProvider ServiceProvider;

        [OneTimeSetUp]
        public void BaseOneTimeSetUp()
        {
            var services = new ServiceCollection();
            services.AddAllQueries();
            services.AddAllServices();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
