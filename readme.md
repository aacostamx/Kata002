# Kata 002

## Summary
Covers schema provisioning, N+1 problem, SQL profiling 

## Pre Reading
- [N + 1](https://www.brentozar.com/archive/2018/07/common-entity-framework-problems-n-1/)

## Discussion
- A common issue is automating schema/seed data provisioning. How does the provided code address this issue?
Using tools like DbUp, SQL Data Generator or creating our own database script or add in-memory objects.
- DbUp is used in a declarative fashion. EF provides additional approaches. Discuss pros/cons of the various mechanisms.
Code-First
Model-First
Database-First
https://www.ryadel.com/en/code-first-model-first-database-first-vs-comparison-orm-asp-net-core-entity-framework-ef-data/

Fluent Validation
Data Annotations

- What is the scope of a migration, given multiple target environments and developers?
Migrations are to ensure that the database structure always matches the currently running application, you can simply migrate the database on application startup for testings or production enviroment.

- Using a SQL Profiler (SSMS or SOS), examine how many calls to SQL Server there are (ignoring any scaffolding from DbUp)? Describe the issue.
It's getting full select and getting related information

- Based on your findings, what are different types of data loading schemes used with EF and some use cases for each of them?
Eager Loading, Lazy Loading And Explicit Loading

Eager Loading
Eager Loading helps you to load all your needed entities at once; i.e., all your child entities will be loaded at single database call. This can be achieved, using the Include method, which returs the related entities as a part of the query and a large amount of data is loaded at once.

Lazy Loading
It is the default behavior of an Entity Framework, where a child entity is loaded only when it is accessed for the first time. It simply delays the loading of the related data, until you ask for it.

- Notice the methods on the model classes, describe some potential issues with them.
	* Research access modifiers, immutability, and decoupling with the above.
	The models are in the same Context class and also they are public for all the classes and the are not decoupling because they have  logic inside the classes
- Compare the EF approach with a mirco ORM such as Dapper and lists some pros and cons of each approach.

## Thought Exercise
How can chosing a tool such as an ORM impact design decisions for an application?
Because it will affect the desing and the way of working for that application
	