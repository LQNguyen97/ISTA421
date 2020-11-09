#  Linh Nguyen
## ASP.NET Core 3 Homework 11

1. How are user authentication and authorization handled in ASP.NET?

	ASP.NET Core Identity system, which integrates neatly into the ASP.NET Core platform and the individual application frameworks. 

2. What ASP.NET package supports the database functionality backing the identity system?

	The ASP.NET Identity system

3. In our Sports Store application, what is the connection string that allows access to our identity database?

	"IdentityConnection": "Server=(localdb)\\MSSQLLocalDB;Database=Identity;MultipleActiveResultSets=true"

4. What methods are required to configure the middleware that supports user authentication and authorization?

	The UseAuthentication and UseAuthorization methods to set up the middleware
	components that implement the security policy

5. When you have multiple databases supporting one ASP.NET application, how do you ensure that specific components use the correct database?

	The **-context** argument to specify the name of the context class associated with the database. 

6. (not in book) In what namespace is the UserManager<T> class located? What is the purpose of the class? What interface(s) does the class require?

	Microsoft.AspNet.Identity
	Exposes user related APIs which will automatically save changes to the UserStore.
	IDisposable

7. How are authentication credentials submitted to the application server? What services does the login manager use in submitting the authentication credentials?

	Authentication credentials are submitted to the POST version of the Login method, which uses the UserManager<IdentityUser> and SignInManager<IdentityUser> services that have been received through the controller’s constructor to authenticate the user and log them into the system

8. How does an ASP.NET application determine the environment in which it is running?

	The IWebHostEnvironment parameter defined by the Configure method describes the environment in which the application is running

9. How do you define configuration settings for different environments, such as development or production?

	The JSON configuration files that are used to define settings such as connection strings can be created so they apply only when the application is in a specific environment, such as development, staging, or production.

10. (not in book) What is Docker? What is a container?

	Docker is a way to package and distribute your applications with all its dependencies. 
	