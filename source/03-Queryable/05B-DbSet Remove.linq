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

var context = new NorthwindEntities();

// DbSet instance is a in memory collection
// filled from the database

// changes to items in the DbSet are not commited to DB, unless .SaveChanges is called.

var nwRegion = context.Regions.Where(r => r.RegionID==44 ).Single();
context.Regions.Dump("Before Remove");
context.Regions.Remove(nwRegion);

//context.SaveChanges();
context.Regions.Dump("After Remove");