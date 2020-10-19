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

var numbers = new List<Int32> { 3, 5, 7, 9, 11 };
var q1 = from n in numbers
				where n < 20
				select n;

q1.Dump("Linq to Objects query");
// The where clause uses the Enumerable.Where
// Implmented via an anonymous method
q1.ToString().Dump("Using the Enumerable Where");

// LINQ to EF queries types with IQueryable
// LINQ to EF creates an expression tree
// Uses the Queryable.Where

var q2 = from p in Products
				 where p.UnitPrice > 100
				 select new { p.ProductName, p.UnitPrice };

q2.Dump("Linq to EF, query");
q2.GetType().GetInterfaces().Dump("DbQuery interfaces");

q2.ToString().Dump("Using the  Where");
q2.Expression.Dump();