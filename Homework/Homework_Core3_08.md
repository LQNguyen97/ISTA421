# Linh Nguyen
## ASP.NET Core 3 Homework 08

1. For chapter 8 of the ASP.NET Core 3 book, what are the three requirements as the author describes them?

	Enhance the Index action method in the HomeController class so that it can filter the Product objects in the repository.
	Revisit and enhance the URL scheme.
	Create a category list that will go into the sidebar of the site, highlighting the current category and linking to others.

2. When adding new routes in Startup.cs, in what order should you add the new routes? Why?

	It is important to add the new routes in the order they are shown. Routes are applied in the order in which they are defined, and you will get some odd effects if you change the order.

3. Does ASP.NET Core 3 handle outgoing HTTP requests as well as incoming requests? If so, what is one reason that this is important?

	Yes, ensure that all the URLs in the application are consistent.

4. What is a view component? Why do you use view components? 166

	Can render Razor partial views. You can use the view component to generate the list of components and then use the more expressive Razor syntax to render the HTML that will display them. 

5. When you use a view component in a view, how is the view component referenced, and what nameing convention do you use?

	Hyphenates ViewComponent and part of the class name, ex. vc:navigation-menu. 

6. When ASP.NET Core 3 needs to create a instance of a component, how does it know what value to give the new instance?

	It will note the need to provide a value for this parameter and inspect the configuration in the Startup class to determine which implementation object should be used.

7. How do ASP.NET Core 3 components get information about a user’s current HTTP request? Why would it be important for the component to get this information?

	Use parameter names that match the input elements in the HTML forms produced by the
	ProductSummary.cshtml view. This allows ASP.NET Core to associate incoming form POST variables with those parameters, meaning I do not need to process the form directly

8. What does the PathAndQuery extension method do with an incoming HTTP request? What does the method do with the return value? What is the return value?

	The extension method generates a URL that the browser will be returned to after the cart has been updated, taking into account the query string, if there is one

9. What is session state?

	Enables you to stores only int, string, and byte[] values and retrieve values for a user as the user navigates ASP.NET pages in a Web application.

10. What three types does a session state store? Suppose you want to store data that has a type that session state does not store, is it possible to do so? If so, how do you do it?

	Int, string, and byte value. Yes, you need to define extension methods to an interface which provides acces to the session state data to serialize the objects into JSON and convert them back. 