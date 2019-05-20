# Kata 002

## Summary
Covers schema provisioning, N+1 problem, SQL profiling 

## Pre Reading
- [N + 1](https://www.brentozar.com/archive/2018/07/common-entity-framework-problems-n-1/)

## Discussion
- A common issue is automating schema/seed data provisioning. How does the provided code address this issue?
- DbUp is used in a declarative fashion. EF provides additional approaches. Discuss pros/cons of the various mechanisms.
- What is the scope of a migration, given multiple target environments and developers?
- Using a SQL Profiler (SSMS or SOS), examine how many calls to SQL Server there are (ignoring any scaffolding from DbUp)? Describe the issue.
- Based on your findings, what are different types of data loading schemes used with EF and some use cases for each of them?
- Notice the methods on the model classes, describe some potential issues with them.
	* Research access modifiers, immutability, and decoupling with the above.
- Compare the EF approach with a mirco ORM such as Dapper and lists some pros and cons of each approach.

## Thought Exercise
How can chosing a tool such as an ORM impact design decisions for an application?

	