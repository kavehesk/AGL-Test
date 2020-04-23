using NSubstitute;
using NUnit.Framework;
using PetOwner.Application.Models;
using PetOwner.Application.Queries.PetsGroupedByOwnerGender;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using PetOwner.Application.Services;
using FluentAssertions;
using System.Threading.Tasks;
using System;
using PetOwner.Application.DependencyInjection;

namespace PetOwner.Application.Test.Queries.PetsGroupedByOwnerGenderTests
{
    [TestFixture]
    class RunTests
    {
        private IPetsGroupedByOwnerGenderQuery _petsGroupedByOwnerGenderQuery;
        private IPetOwnerService _petOwnerService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var services=new ServiceCollection(); ;
            services.AddAllQueries();
            
            _petOwnerService = Substitute.For<IPetOwnerService>();
            services.AddSingleton(_petOwnerService);
            var serviceProvider = services.BuildServiceProvider();

            _petsGroupedByOwnerGenderQuery = serviceProvider.GetService<IPetsGroupedByOwnerGenderQuery>();
        }


        [Test]
        public async Task Returns_Nothing_When_There_Is_No_Owners()
        {
            //Arrange
            _petOwnerService.GetAllOwnersAndTheirPets().Returns(new List<OwnerPet>());

            //Act
            var viewModel =await _petsGroupedByOwnerGenderQuery.Run(PetType.Cat);

            //Assert
            viewModel.Should().NotBeNull();
            viewModel.Genders.Should().BeEmpty();
        }

        [Test]
        public void Returns_Nothing_When_There_Is_No_Owner1s()
        {
            //Arrange
            _petOwnerService.GetAllOwnersAndTheirPets().Returns(new List<OwnerPet>());

            //Act
            //var viewModel=

            ////Assert
            //defaultServingSize.Should().NotBeNull();
            //defaultServingSize.Quantity.Value.Should().Be(1);
            //defaultServingSize.Name.Should().Be(FoodMeasurementType.Mass.UnitName);
        }
    }
}
