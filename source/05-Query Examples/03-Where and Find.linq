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

// Use find to get an entity with the specified key value
// faster if item is cached in context

// Microsoft Docs: Find is different from using a query in two significant ways:

// A round-trip to the database will only be made if the entity with the given key is not found in the context.
// Find will return entities that are in the Added state.
// That is, Find will return entities that have been added to the context but have not yet been saved to the database.

Products.Where(p =>p.ProductID==4 ).Dump();
//Products.Where(p =>p.ProductID==4 ).Dump();
 Products.Find(4).Dump();
//Products.Find(5).Dump();