<Query Kind="Statements">
  <Connection>
    <ID>c54576d1-888b-4050-976b-0c662e22b616</ID>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe</CustomAssemblyPath>
    <CustomTypeName>ConsoleForEF.NorthwindEntities</CustomTypeName>
    <AppConfigPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe.config</AppConfigPath>
  </Connection>
  <Reference Relative="..\..\..\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// DBContext

// DbContext represents a session with a database
// it is responsible for opening and closing the database connection

 // it manages change tracking, so that it know what SQL to generate
 // for updates, deletes and inserts.
 
 // it supports caching, so that subsequent  request for same data hits the cache.
 
 // it uses transactions when SaveChanges is called.
 
 var context = new NorthwindEntities();
 
 var type = context.GetType();
 type.FullName.Dump("Context Type");
type.BaseType.FullName.Dump("Base Type");