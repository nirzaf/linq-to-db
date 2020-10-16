<Query Kind="Statements">
  <Connection>
    <ID>c54576d1-888b-4050-976b-0c662e22b616</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe</CustomAssemblyPath>
    <CustomTypeName>ConsoleForEF.NorthwindEntities</CustomTypeName>
    <AppConfigPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe.config</AppConfigPath>
  </Connection>
  <Namespace>System.Data.Entity</Namespace>
</Query>

var context = new NorthwindEntities();

// The DB joins are defined in the EF mapping
// this simplifies common queries.

//context.Customers.Dump();


var q2 = from o in Order_Details
				 where o.Order.CustomerID == "ISLAT"
				 				 select new {o.Order.Customer.CompanyName, o.Order.OrderDate, o.Product.ProductName, Employee= o.Order.Employee.FirstName + " " + o.Order.Employee.LastName };
					
q2.Take (10).Dump();