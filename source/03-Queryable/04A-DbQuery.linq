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

// DbSet and DbQuery implement IQueryable
// DbQuery represents a non-generic LINQ to Entities query against a DbContext. (EF 6.x)
// EF Core 2.1, useful to represent non-updateable database Views 
// EF Core 3, removed from EF

// Regions table in EF ORM is mapped to the DbContext.Regions property
// public virtual DbSet<Region> Regions { get; set; }
// a row in the Regions table is mapped to the Region class


// EF 6

context.Regions.Dump();
var q1 = from r in context.Regions
				 where r.RegionID == 2
				 select r;
// get the reference
q1.Dump();
