using PetOwner.Application.Models;
using System.Collections.Generic;

namespace PetOwner.Application.Test.TestDataSources
{
    static class TestData
    {
        public static List<Owner> Owners = new List<Owner>()
        {
           new Owner
            {
                Name = "Bob",
                Age = 23,
                Gender = Gender.Male,
                Pets = new List<Pet>()
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
            new Owner
            {
                Name = "Jennifer",
                Age = 18,
                Gender = Gender.Female,
                Pets = new List<Pet>()
                {
                    new Pet()
                    {
                        Name="Garfield",
                        Type=PetType.Cat
                    }
                }
            },
            new Owner
            {
                Name = "Steve",
                Age = 45,
                Gender = Gender.Male,
                Pets = new List<Pet>()
            },
            new Owner
            {
                Name = "Fred",
                Age = 40,
                Gender = Gender.Male,
                Pets = new List<Pet>()
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
            new Owner
            {
                Name = "Samantha",
                Age = 40,
                Gender = Gender.Female,
                Pets = new List<Pet>()
                {
                    new Pet()
                    {
                        Name="Tabby",
                        Type=PetType.Cat
                    }
                }
            },
            new Owner
            {
                Name = "Alice",
                Age = 64,
                Gender = Gender.Female,
                Pets = new List<Pet>()
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
            }
        };
    }
}
