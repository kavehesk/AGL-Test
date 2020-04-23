using PetOwner.Application.Models;
using System.Collections.Generic;

namespace PetOwner.Application.Test.TestData
{
    static class OwnerPetCollection
    {
        public static List<OwnerPet> OwnerPetTestData = new List<OwnerPet>()
        {
            new OwnerPet()
            {
                Owner=new Owner
                {
                    Name="Bob",
                    Age=23,
                    Gender= Gender.Male
                },
                Pets=new List<Pet>()
                {
                    new Pet()
                    {
                        Name="Garfield",
                        Type=PetType.Cat
                    },
                    new Pet()
                    {
                        Name="Fido",
                        Type=PetType.Dog
                    }
                }
            },
            new OwnerPet()
            {
                 Owner=new Owner
                {
                    Name="Jennifer",
                    Age=18,
                    Gender= Gender.Female
                },
                Pets=new List<Pet>()
                {
                    new Pet()
                    {
                        Name="Garfield",
                        Type=PetType.Cat
                    }
                }
            },
            new OwnerPet()
            {
                 Owner=new Owner
                {
                    Name="Steve",
                    Age=45,
                    Gender= Gender.Male
                },
                Pets=new List<Pet>()
            }
            ,
             new OwnerPet()
            {
                 Owner=new Owner
                {
                    Name="Fred",
                    Age=40,
                    Gender= Gender.Male
                },
                Pets=new List<Pet>()
                {
                    new Pet()
                    {
                        Name="Tom",
                        Type=PetType.Cat
                    },
                    new Pet()
                    {
                        Name="Max",
                        Type=PetType.Cat
                    },
                    new Pet()
                    {
                        Name="Sam",
                        Type=PetType.Dog
                    },                   
                    new Pet()
                    {
                        Name="Jim",
                        Type=PetType.Cat
                    }
                }
            },
            new OwnerPet()
            {
                 Owner=new Owner
                {
                    Name="Samantha",
                    Age=40,
                    Gender= Gender.Female
                },
                Pets=new List<Pet>()
                {
                    new Pet()
                    {
                        Name="Tabby",
                        Type=PetType.Cat
                    }
                }
            },
            new OwnerPet()
            {
                 Owner=new Owner
                {
                    Name="Alice",
                    Age=64,
                    Gender= Gender.Female
                },
                Pets=new List<Pet>()
                {
                    new Pet()
                    {
                        Name="Simba",
                        Type=PetType.Cat
                    },
                    new Pet()
                    {
                        Name="Nemo",
                        Type=PetType.Fish
                    }
                }
            },

        };
    }
}
