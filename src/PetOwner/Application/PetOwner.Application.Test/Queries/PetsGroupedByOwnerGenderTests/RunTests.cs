using NSubstitute;
using NUnit.Framework;
using PetOwner.Application.Queries.PetsGroupedByOwnerGender;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using PetOwner.Application.Services;
using FluentAssertions;
using System.Threading.Tasks;
using System.Linq;
using PetOwner.Application.DependencyInjection;
using PetOwner.Application.Test.TestDataSources;
using PetOwner.Application.ReadModels;

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
            var services = new ServiceCollection(); ;
            
            services.AddAllQueries();

            _petOwnerService = Substitute.For<IPetOwnerService>();
            services.AddSingleton(_petOwnerService);

            var serviceProvider = services.BuildServiceProvider();

            _petsGroupedByOwnerGenderQuery = serviceProvider.GetService<IPetsGroupedByOwnerGenderQuery>();
        }

        [Test]
        public async Task Returns_Empty_List_When_There_Is_No_Owners()
        {
            //Arrange
            _petOwnerService.GetAllOwners().Returns(new List<Owner>());

            //Act
            var viewModel = await _petsGroupedByOwnerGenderQuery.Run(PetType.Cat);

            //Assert
            viewModel.Should().NotBeNull();
            viewModel.Genders.Should().BeEmpty();
        }

        [Test]
        public async Task Returns_Female_Group_When_All_Cat_Owners_Are_Female()
        {
            //Arrange
            var femaleOwners = TestData.Owners.Where(x => x.Gender == Gender.Female).ToList();
            _petOwnerService.GetAllOwners().Returns(femaleOwners);

            //Act
            var viewModel = await _petsGroupedByOwnerGenderQuery.Run(PetType.Cat);

            ////Assert
            viewModel.Genders.Should().HaveCount(1);
            viewModel.Genders.First().Gender.Should().Be(Gender.Female.ToString());
        }

        [Test]
        public async Task Returns_Pet_Names_Alphabetically_Ordered()
        {
            //Arrange
            _petOwnerService.GetAllOwners().Returns(TestData.Owners);

            //Act
            var viewModel = await _petsGroupedByOwnerGenderQuery.Run(PetType.Cat);

            //Assert
            viewModel.Genders
                     .Single(x => x.Gender == Gender.Male.ToString())
                     .PetNames.Should().BeInAscendingOrder();

            viewModel.Genders
                     .Single(x => x.Gender == Gender.Female.ToString())
                     .PetNames.Should().BeInAscendingOrder();
        }

        [Test]
        public async Task Returns_Only_The_Requested_Pet_Type()
        {
            //Arrange
            _petOwnerService.GetAllOwners().Returns(TestData.Owners);

            //Act
            var viewModel = await _petsGroupedByOwnerGenderQuery.Run(PetType.Cat);

            //Assert
            var returnedPetNames = viewModel.Genders.SelectMany(x => x.PetNames);
            var noneCatNames =
                TestData.Owners
                        .SelectMany(x => x.Pets)
                        .Where(x => x.Type != PetType.Cat)
                        .Select(x => x.Name);

            returnedPetNames.Should().NotContain(noneCatNames);
        }
    }
}
