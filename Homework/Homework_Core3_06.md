# Linh Nguyen
## ASP.NET Core 3 Homework 06

1.What is unit testing as defined by the book?

	Unit testing is a form of testing in which individual components are isolated from the rest of the application so their behavior can be thoroughly validated

2.What is the convention for creating unit tests in ASP.NET Core applications?

	Use the dotnet new command with the project template for your preferred test
	framework

3.Name three unit test project tools used for ASP.NET Core applications.

	mstest: This template creates a project configured for the MS Test framework, which is produced by Microsoft
	nunit: This template creates a project configured for the NUnit framework.
	xunit: This template creates a project configured for the XUnit framework.

4.What is the convention for naming unit tests in ASP.NET Core applications?

	The convention is to name the unit test project <ApplicationName>.Tests.

5.What is the convention for naming the test classes in AP.NET Core? What is the convention for naming the methods in the test classes?

	The name of the class describes what is being tested
	The name of the test methods describes what the test does

6.What is the purpose of the Fact attribute in Xunit? (not in book) What is the purpose of the Theory attribute in Xunit?

	Fact: To indicate that it is a test.
	Theories: tests that are true for a particular set of data passed as argument to the method

7.Describe the different elements of the AAA testing pattern.

	Arrange refers to setting up the conditions for the test 
	Act refers to performing the test 
	Assert refers to verifying that the result was the one that was expected.

8.Describe the use of the methods in the Assert class. Describe the purpose, parameters, and return value of the Assert.Equals() method.

	Used to check that the outcome of an action is the one that is expected.
	This method asserts that the result is equal to the expected outcome. There are overloaded versions of this method for comparing different types and for comparing collections. There is also a version of this method that accepts an additional argument of an object that implements the IEqualityComparer<T> interface for comparing objects.

9.What is the key to isolating a component for testing?

	The key to isolating components is to use C# interfaces. (PG. 118)

10.What is a mocking package? What does it do?

	Fake implementations required for testing. Make it easy to create fake-or mock-objects for tests.

11.(not in book) What is the difference between the Setup() and the SetupGet() methods of Moq?

	Setup() can be used for mocking a method or a property.
	SetupGet() is specifically for mocking the getter of a property.