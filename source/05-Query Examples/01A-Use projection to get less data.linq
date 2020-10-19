<Query Kind="Statements">
  <Connection>
    <ID>aef7d1f3-9ecd-4b72-8ac7-667df71c9301</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe</CustomAssemblyPath>
    <CustomTypeName>ConsoleForEF.NorthwindEntities</CustomTypeName>
    <AppConfigPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe.config</AppConfigPath>
  </Connection>
  <Reference Relative="..\..\..\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// Where clause filters the number of rows returned 
// Select clause (aka projection) filters the number of columns returned

Customers.Count().Dump("# rows in Customers");
var q1 = from c in Customers
				where c.City.StartsWith ("S")
				select c;
				
// check the generated SQL, this gets all columns
q1.Dump ();

var q2 = from c in Customers
				 where c.City.StartsWith ("S")
				 select new {c.CompanyName, c.Address, c.City};
q2.Dump();