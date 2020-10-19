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

// use Take/Skip to get less rows without a where clause
// Take: Returns contiguous elements from the start of a sequence.
// Skip: Bypasses elements in a sequence and then returns the remaining elements.
var q1 = from p in Products
				 orderby p.ProductID
				 select new {p.ProductID, p.ProductName, p.UnitPrice};
				 
var count = q1.Count();

count.Dump("Products count");

var pageSize = 5;
q1.Take(pageSize).Dump("First page");
q1.Skip(pageSize).Take (pageSize).Dump("Next page");