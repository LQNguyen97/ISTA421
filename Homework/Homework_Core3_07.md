# Linh Nguyen
## ASP.NET Core 3 Homework 07

1.For the Sports Store application, what requirements does the author identify for implementation?

	Online product catalog that customers can browse by category and page, a shopping cart where users can add and remove products, and a checkout where customers can enter their shipping details.
	An administration area that includes create, read, update, and delete (CRUD) facilities for managing the catalog.
	Protect it so that only logged-in administrators can make changes

2.What is the purpose of the Startup class in ASP.NET Core applications?

	The Startup class is responsible for configuring the ASP.NET Core application

3.What is the purpose of the CofitureServices method in the Startup class?

	The ConfigureServices method is used to set up objects, known as services, that can be used throughout the application and that are accessed through a feature called dependency injection

4.What is a request pipeline and how does it work?

	Specifies how the application should respond to the HTTP request

5.What is the View Start class and how do we use it?

	The view start file tells Razor to use a layout file in the HTML that it generates, reducing the amount of duplication in views.
	Create the view, add a Razor layout named _Layout.cshtml

6.What is the feature in ASP.NET Core that generates the database schema for us? What does the file created by this feature contain?

	Entity Framework Core is the Microsoft object-to-relational mapping (ORM) framework, and it is the most widely used method of accessing databases in ASP.NET Core projects.

7.When ASP.NET Core sees that a controller instance needs to be created, and that the controller object required another object that implements some interface, how does it determine which interface should be implemented?

	ASP.NET Core consults the configuration in the Startup class, which tells it that EFStoreRepository should be used and that a new instance should be created for every request.

8.Explain how the paging mechanism works. How does the application calculate the number of pages required? How is this data passed to the view?

	Pass information to the view about the number of pages available, the current page, and the total number of products in the repository.
	View model class, which is used specifically to pass data between a controller and a view

9.How does the book describe dependency injection? How is dependency injection used?

	Dependency Injection makes it easy to create loosely coupled components, which typically means that components consume functionality defined by interfaces without having any firsthand knowledge of which implementation classes are being used.
	The Startup class is used to specify which implementation classes are used to deliver the functionality specified by the interfaces used by the application. Services can be explicitly requested through the IServiceProvider interface or by declaring constructor or method parameters.

10.How are the routes in MapDefaultControllerRoute() method arranged? Why is this important?

	The endpoint routing feature is added to the request pipeline with the UseRouting and UseEndpoints methods
	To register the MVC Framework as a source of endpoints
