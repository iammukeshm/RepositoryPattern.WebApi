# Repository Pattern in ASP.NET Core

In this extensive guide, we will go through everything you will need to know about Repository Pattern in ASP.NET Core, Generic Repository Patterns, Unit of Work and related topics. We will build a project right from scratch where we implement a clean architecture to access data.

A Repository pattern is a design pattern that mediates data from and to the Domain and Data Access Layers ( like Entity Framework Core / Dapper). Repositories are classes that hide the logics required to store or retreive data. Thus, our application will not care about what kind of ORM we are using, as everything related to the ORM is handled within a repository layer. This allows you to have a cleaner seperation of concerns. Repository pattern is one of the heavily used Design Patterns to build cleaner solutions.

Read more about the step-by-step implementation on https://www.codewithmukesh.com/blog/repository-pattern-in-aspnet-core/
