using NSubstitute;
using NUnit.Framework;
using PetOwner.Application.Models;
using PetOwner.Application.Queries.PetsGroupedByOwnerGender;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using PetOwner.Application.Services;

namespace PetOwner.Application.Test.Queries.PetsGroupedByOwnerGenderTests
{
    [TestFixture]
    class RunTests:TestBase
    {
        private IPetOwnerService _petOwnerService;
        private IPetsGroupedByOwnerGenderQuery _petsGroupedByOwnerGenderQuery;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _petOwnerService = Substitute.For<IPetOwnerService>();
            _petsGroupedByOwnerGenderQuery = ServiceProvider.GetService<IPetsGroupedByOwnerGenderQuery>();
        }


        [Test]
        public void Returns_Nothing_When_There_Is_No_Owners()
        {
            //Arrange
            _petOwnerService.GetAllOwnersAndTheirPets().Returns(new List<OwnersAndTheirPets>());

            //Act
            //var viewModel=

            ////Assert
            //defaultServingSize.Should().NotBeNull();
            //defaultServingSize.Quantity.Value.Should().Be(1);
            //defaultServingSize.Name.Should().Be(FoodMeasurementType.Mass.UnitName);
        }

        [Test]
        public void Returns_Nothing_When_There_Is_No_Owner1s()
        {
            //Arrange
            _petOwnerService.GetAllOwnersAndTheirPets().Returns(new List<OwnersAndTheirPets>());

            //Act
            //var viewModel=

            ////Assert
            //defaultServingSize.Should().NotBeNull();
            //defaultServingSize.Quantity.Value.Should().Be(1);
            //defaultServingSize.Name.Should().Be(FoodMeasurementType.Mass.UnitName);
        }
    }
}
