<Query Kind="Statements">
  <Connection>
    <ID>c54576d1-888b-4050-976b-0c662e22b616</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe</CustomAssemblyPath>
    <CustomTypeName>ConsoleForEF.NorthwindEntities</CustomTypeName>
    <AppConfigPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe.config</AppConfigPath>
  </Connection>
  <Reference Relative="..\..\..\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

var context = new NorthwindEntities();


var q1 = from p in context.Products
					orderby p.ProductID
				  select new {p.ProductID, p.ProductName, p.UnitPrice};
				 

var skipValue = 5;
var takeValue = 5;
// hard coded values
q1.Skip (takeValue).Take (skipValue).Dump("hard coded, 5");

// dynamic values

q1.Skip(()=>takeValue).Take(()=>skipValue).Dump("dynamic, 5");


takeValue = 12;
// hard coded values
q1.Skip(takeValue).Take(skipValue).Dump("hard coded, take 12");

// dynamic values
q1.Skip(() => takeValue).Take(() => skipValue).Dump("dynamic, take 12");