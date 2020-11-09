# Linh Nguyen
## Homework C# 21

1.What is the difference in the purposes of SQL and LINQ? In other words, why do we need two different query languages? Does LINQ replace SQL? Does SQL make LINQ unnecessary?

	LINQ provides syntax and semantics very reminiscent of SQL and with many of the same advantages. You can change the underlying structure of the data being queried without needing to change the code that actually performs the queries. You should be aware that although LINQ looks similar to SQL, it is far more flexible and can handle a wider variety of logical data structures.

2.What is the one essential requirement for the data structures used with LINQ? Why is this requirement important?

	LINQ requires the data to be stored in a data structure that implements the IEnumerable or IEnumerable interface.

3.Were does the LINQ Select() method live?

	It is an extension method of the Enumerable class. The Enumerable class is located in the System.Linq namespace.

4.(Select) Explain, token by token, each token in this line of code:
IEnumerable<string> customerFirstNames = customers.Select(cust => cust.FirstName);

	Uses the Select method of the customers array to generate an IEnumerable object named customerFirstNames. (It is of type IEnumerable because the Select method returns an enumerable collection of customer first names, which are strings.) The foreach statement iterates through this collection of strings, printing out the first name of each customer.

5.(Filter) Explain, token by token, each token in this line of code:
IEnumerable<string> usCompanies = addresses.Where(addr =>String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);

	The variable addr is an alias for a row in the addresses array, and the lambda expression returns all rows where the Country field matches the string “United States”. The Where method returns an enumerable collection of rows containing every field from the original collection. The Select method is then applied to these rows to project only the CompanyName field from this enumerable collection to return another enumerable collection of string objects.

6.(OrderBy) Explain, token by token, each token in this line of code: IEnumerable<string> companyNames = addresses.OrderBy(addr =>addr.CompanyName).Select(comp => comp.CompanyName);

	This method identifies the expressions that you want to use to sort the data. For example, you can display the name of each company in the addresses array in ascending order = return type of equals either true or false 
	uscompany is a variable of type inumerable.
	
7.(Group) Explain, token by token, each token in this line of code:
var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);

	The result of the GroupBy method is an enumerable set of groups, each of which is an enumerable set of rows. In the example just shown, the enumerable set companiesGroupedByCountry is a set of countries. The items in this set are themselves enumerable collections containing the companies for each country in turn.
	addr contains all the records in the address
	companyname is the property
	orderby returns an object
	addresses. is a type of ienumerable .
	addrs is a variable that holds each element --> country is a property
	groupby is a method
	
8.(Distinct) Explain, token by token, each token in this line of code:
int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();

	The addresses array includes only three different countries; it just so happens that United States and United Kingdom both occur twice. You can eliminate duplicates from the calculation by using the Distinct method
	addresses is the name of the array
	A series of dots, (.) each element whether its a method or property will return objects therefore select will return objects
	
9.(Join) Explain, token by token, each token in this line of code:
var companiesAndCustomers = customers.Select(c =>new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs =>custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) =>new {custs.FirstName, custs.LastName, addrs.Country });

	the Join method joins the enumerable collection containing the FirstName, LastName, and CompanyName fields from the customers array with the rows in the addresses array. The two sets of data are joined where the value in the CompanyName field in the customers array matches the value in the CompanyName field in the addresses array. The result set includes rows containing the FirstName and LastName fields from the customers array with the Country field from the addresses array.

10.Explain the difference between a deferred collection and a static, cached collection.

	Deferred only displays queries at iteration so any updates will be displayed and static makes a copy of the data and can not be updated.
	Cached collection you get all the data, deferred collection you only get 1 at a time.