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

// get orders in date range

TimeSpan thirtyDays = TimeSpan.FromDays(30);

// get an order
var q1 = from o in Orders
				 where o.OrderID == 10250
				 	select new {o.OrderID, o.OrderDate, o.ShipName};

q1.Take(12).Dump();

var originalDate = q1.First().OrderDate;
var futureDate = originalDate + thirtyDays;
var q2= from o in Orders
				where o.OrderDate > originalDate & o.OrderDate < futureDate
				select new {o.OrderID, o.OrderDate, o.ShipName};

q2.Dump();