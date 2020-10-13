<Query Kind="Program">
  <Connection>
    <ID>54bf9502-9daf-4093-88e8-7177c129999f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Provider>System.Data.SqlServerCe.4.0</Provider>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\DemoDB.sdf</AttachFileName>
    <Persist>true</Persist>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
  </Connection>
  <Reference Relative="..\Assets\DB\System.Data.SqlServerCe.dll">C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\DB\System.Data.SqlServerCe.dll</Reference>
  <Namespace>System.Data.SqlClient</Namespace>
  <Namespace>System.Data.SqlServerCe</Namespace>
  <Namespace>System.Numerics</Namespace>
</Query>

void Main()
{
	// Represents the main entry point for the LINQ to SQL framework.
	string cnString = @"data source='C:\Users\WR\AppData\Roaming\LINQPad\DemoDB.sdf'";

	using (var conn = new System.Data.SqlServerCe.SqlCeConnection(cnString))
	{
		conn.Open();

		var context = GetDataContext(conn);

		context.
		conn.Close();

	}

	
}

// Define other methods and classes here
public DataContext GetDataContext (SqlCeConnection conn)
{
	var myContext = new DataContext(conn,);
	var product = context.Products.Where(p => p.Id == productId).SingleOrDefault();
	return null;
}