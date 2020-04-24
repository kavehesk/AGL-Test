# AGL-Test
This repository contains a solution developed for AGL developer test. 

## Application URL
The result has been deployed to an Azure WebApp and can be accessed at [PetOwners](https://petownerweb20200424122316.azurewebsites.net/)

## Design Objectives
— High cohesion 
— Low coupling
— Separation of concerns

Please note that some parts of the application have been over engineered for showcasing purposes. 

## Solution structure
#### Web : 
This layer contains presentation logic. Also, as it is the start-up project, application settings are stored in appsettings.json and communicated to other parts of application by [Option Pattern](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-3.1).
#### Application: 
This layer contains the business logic of the application. All other layers are dependent on Application project and the application layer has minimum dependency. Following the test instructions, we only need to create one query to fulfill the requirement so there is no need to create a writing domain model, with all the complexities involved, and only a read-only model will suffice. The read model follows the [Ubiquitous Language](https://martinfowler.com/bliki/UbiquitousLanguage.html) of the PetOwner [Bounded Context](https://martinfowler.com/bliki/BoundedContext.html) which is slightly different to the [AGL json service](http://agl-developer-test.azurewebsites.net/people.json) language. This difference was introduced only for showcasing purposes and allowed us to implement an [anti-corruption layer](https://docs.microsoft.com/en-us/azure/architecture/patterns/anti-corruption-layer) which is done in the infrastructure layer.

Besides read models, queries are another important part of the application layer. They implement the queries which work on the read model and return view models based on the requirement of each use case. View models are DTOs (Data Transfer Objects) designed specifically for each requirement. So they are query-specific.

Services are another part of the application layer. Services can either be implemented in the application or infrastructure layer based on what they do. For this requirement, the service is responsible for retrieving data and doesn't contain any application specific logic. Consequently, the interface is defined in the application layer and the implementation resides in the infrastructure layer.

A unit test project tests the application logic. The following tools are used for unit testing:
- [NSubstitue](https://nsubstitute.github.io/) which is a mocking library
- [FluentAssertions](https://fluentassertions.com/)
- [NUnit](https://nunit.org/)
- [.NET Core Dependency Injection ](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1)

#### Infrastructure: 
This layer helps the application layer to fulfill its responsibility. It contains application service implementations, model translations and all the required classes for interservice communication.



## Dependency Injection
Dependency injection is used throughout the project and each project is responsible for setting up its own services. Doing so, the same setup process can be used in unit tests in addition to run-time.

