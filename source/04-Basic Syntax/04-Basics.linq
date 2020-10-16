<Query Kind="Statements">
  <Connection>
    <ID>5124b608-85c8-4a13-8851-76874fa8fc72</ID>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe</CustomAssemblyPath>
    <CustomTypeName>ConsoleForEF.ToursEntities</CustomTypeName>
    <AppConfigPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe.config</AppConfigPath>
  </Connection>
  <Reference Relative="..\..\..\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

//   a pass through query, returns all rows and columns
//  same as SELECT * FROM TABLE_NAME in SQL


var context = new NorthwindEntities ();
context.Shippers.Dump();
var q1 = from r in context.Regions
				 select r;
var q2 = from t in context.Territories
				select t;
q1.Dump();
q2.Dump();				
