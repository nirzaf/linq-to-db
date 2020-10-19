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

// The DB joins are defined in the EF mapping
// In the entity classes they are represented as Navigation properties.
// Navigation properties provide a way to navigate an association between two entity types 
// They allow you to navigate and manage relationships in both directions

// this simplifies common LINQ queries.



var q2 = from o in Order_Details
					where o.Order.CustomerID =="ISLAT"
					select o;
					
q2.Dump();