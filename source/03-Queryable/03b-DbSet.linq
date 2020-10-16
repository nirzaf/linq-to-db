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

// DbSet instance is a in memory collection
// filled from the database

// changes to items in the DbSet are not commited to DB, unless .SaveChanges is called.

 context.Regions.Dump();
 var regionRow = context.Regions.First();
 regionRow.Dump();
 regionRow.RegionDescription = "Eastern";
 context.Regions.Dump();
 //context.SaveChanges();