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

// Use Find to get an entity with the specified key value
// This is faster if item is cached in the context (DbContext in this example).

// Microsoft Docs: Find is different from using a query:
// A round-trip to the database happens if the entity 
// with the given key is not found in the context.


 Products.Where(p => p.ProductID == 4).Single().Dump();
 Products.Where(p => p.ProductID == 4).Single().Dump();
//Products.Find(4).Dump();
//Products.Find(4).Dump();