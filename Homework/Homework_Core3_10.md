# Linh Nguyen
## ASP Core3 Homework 10

1. What is Blazor?

	Blazor is a new addition to ASP.NET Core, and it combines client-side JavaScript code with server-side code executed by ASP.NET Core, connected by a persistent HTTP connection.

2. What do the methods AddServerSideBlazor() and MapBlazorHub() do?

	The AddServerSideBlazor method creates the services that Blazor uses
	MapBlazorHub method registers the Blazor middleware components.

3. Where are Blazor files conventionally located?

	The conventional location for Blazor files is within the Pages folder

4. What is the purpose of the Routed.razor file?

	component will use the browser’s current URL to locate a Razor Component that can be displayed to the user. If no matching component can be found, then an error message is displayed

5. (Not in book) What is the purpose of the <NavLink> element, and what does it do?

	A component that renders an anchor tag, automatically toggling its 'active' class based on whether its 'href' matches the current URI.
	Allow you to navigate to different routes defined in the application.

6. What is the purpose of an @code { ... } block? Where are they located and what is their purpose?

	The @page directives specify the URLs for which this component will be displayed

7. How can a single component be configured to present two different sets of data without the need to duplicate code and content?

	The @inherits expression ensures that this component gets its own repository object, which ensures its operations are separate from those performed by other components displayed to the same user. And to avoid repeatedly querying the database the repository is used only when the component is initialized.

8. What is CRUD? What are the equivalent SQL statements?

	Create, read, update, and delete items in the collection
	database operations Create, Read, Update, and Delete.

9. Does Blazor use the same approach to validation as the rest of ASP.NET Core? If not, how is Blazor different?

	Blazor uses the same approach to validation as the rest of ASP.NET Core

10. What is the purpose of the Inject attribute?

	Inject attribute to declare that it requires an implementation of the interface

11. What is the NavigationManager class? What does it do?

	Used to programmatically navigate between components without triggering a new HTTP request.