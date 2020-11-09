# Linh Nguyen
## ASP.NET HW 09

1. The text contains the folowing:
	I defined a Cart model class in the previous chapter and demonstrated how it can be stored using the session feature, allowing the user to build up a set of products for purchase. The responsibility for managing the persistence of the Cart class fell to the Cart Razor Page, which has to deal with getting and storing Cart objects as session data. The problem with this approach is that I will have to duplicate the code that obtains and stores Cart objects in any other Razor Page or controller that uses them. 
In your own words, describe thee “problem” the author identifies and explain why the proposed solution is not satisfactory. 
	
	The problem is that we will have to duplicate the code into anything other Page or controller that use them. Duplicate code will be very hard to maintain and figure out bugs.	

2. What are services, and how do they work.

	Service/Dependency injection, used to hide details of how interfaces are implemented from the components that depend on them

3. (Not in book) The author states, “The static GetCart method is a factory for creating SessionCart objects and providing them with an ISession object so they can store themselves.” What does he mean by calling the GetCart method a factory?

	Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

4. What does the AddScoped method do?

	Within the same HTTP request, if the service is required in multiple places, like in the view and in the controller, then the same instance is provided for the entire scope of that HTTP request.

5. How is an HTML form element with a tag handler of asp-page-handler programmed to execute the functionality exposed by the form?

	The handler method uses the value it receives to locate the item in the cart and remove it.

6. What does the BindNever attribute do? Why is it useful?

	Prevents the user from supplying values for these properties in an HTTP request
	It stops ASP.NET Core using values from the HTTP request to populate sensitive or important model properties.

7. What does the tag helper <asp-for> do?

	This attribute extracts the name of the specified model property into the rendered HTML.

8. Using Entity Framework, how do you add a new model to your database?

	Right click on the project profile model, click add, click new class.

9. What, speciically, does this command do: dotnet ef migrations add Model?

	This command tells Entity Framework Core to take a new snapshot of the application data model, work out how it differs from the previous database version, and generate a new migration called Model

10. How does Entity Framework understand to load data that is contained in multiple tables? For example, suppose you want to load data from both Orders and Order.Details. What LINQ methods accomplish this?

	Entity Framework Core requires instruction to load related data if it spans multiple tables
	Include and ThenInclude methods to specify that when an Order object is read from the database

11. Why do we validate data on the client side? Why do we validate data on the server side? What are the advantages and disadvantages of cliet side validation and server side validation?

	Server-side Validation : To validate the user's submitted data.
		 The problem with server-side validation is that the user isn’t told about errors until after the data has been sent to the server and processed and the result page has been generated
	Client-side validation : To check the values that the user has entered before the form data is sent to the server
