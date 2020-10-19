<Query Kind="Statements">
  <Connection>
    <ID>aef7d1f3-9ecd-4b72-8ac7-667df71c9301</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe</CustomAssemblyPath>
    <CustomTypeName>ConsoleForEF.NorthwindEntities</CustomTypeName>
    <AppConfigPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe.config</AppConfigPath>
  </Connection>
</Query>

// Extension methods

// Call a single extension method

var orderedResults = Products.OrderBy(p => p.ProductName);

var filteredResults = Products.Where(p => p.UnitsInStock == 0);

orderedResults.Dump();
filteredResults.Dump();

// Learn more about LINQ 
// https://www.linkedin.com/learning/topics/linq