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

// Pipeline the extension methods.

var pipelinedResults = Products.OrderBy(p =>  p.UnitPrice )
																.Where(p =>  p.UnitsInStock ==0 )
																.Select(p => p.ProductName);

pipelinedResults.Dump();