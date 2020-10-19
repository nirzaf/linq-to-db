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

var colors = new List<string>
						{ "Green", "Blush", "Yellow", "Red", "Orange",
							"Burgandy", "Purple", "White", "Black", "Blue" ,"Bronze"};
							
var q1 = colors.Where(c => c.StartsWith("B") );
q1.Dump();

var q2 = Products.Where(p => p.ProductName.StartsWith("F"));
q2.Dump();