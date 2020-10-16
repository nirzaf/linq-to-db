<Query Kind="Statements">
  <Connection>
    <ID>c54576d1-888b-4050-976b-0c662e22b616</ID>
    <Persist>true</Persist>
    <Driver>EntityFrameworkDbContext</Driver>
    <CustomAssemblyPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe</CustomAssemblyPath>
    <CustomTypeName>ConsoleForEF.NorthwindEntities</CustomTypeName>
    <AppConfigPath>C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\ExeEF\ConsoleForEF.exe.config</AppConfigPath>
  </Connection>
</Query>

var context = new NorthwindEntities();

// The DB joins are defined in the EF mapping
// In the entity classes they are represented as Navigation properties.
// Navigation properties provide a way to navigate an association between two entity types 
// They allow you to navigate and manage relationships in both directions

// this simplifies common LINQ queries.


 var q1 = from o in Order_Details
 					select o;
q1.Take (10).Dump();

var q2 = from o in Order_Details
					where o.Order.CustomerID =="VICTE"
					select o;
					
q2.Take (10).Dump();