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

// Add more clauses


var allProducts = from p in Products
				 					select p;
var filteredProducts = from p in Products
											 where p.UnitsInStock ==0
											select p;

var orderedProducts = from p in Products
											orderby p.UnitPrice
											select p;
											
// instead of pipelining, add clauses to query expression

allProducts.Dump();
filteredProducts.Dump();
orderedProducts.Dump();



// Learn more about LINQ 
// https://www.linkedin.com/learning/topics/linq