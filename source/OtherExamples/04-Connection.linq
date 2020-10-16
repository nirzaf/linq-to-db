<Query Kind="Program">
  <Reference Relative="..\Assets\DB\System.Data.SqlServerCe.dll">C:\Users\WR\Source\Repos\linq-databases-2858036\source\Assets\DB\System.Data.SqlServerCe.dll</Reference>
  <Namespace>System.Data.SqlClient</Namespace>
  <Namespace>System.Numerics</Namespace>
</Query>

// LINQPad provides an easy way to get data context for a database
// this example bypasses the LINQPad system and uses basic ADO.NET
// Note:  since this is .NET core
// add System.Data.Common and System.Data.SqlClient nuget packages.
void Main()
{
	var ds = new DataSet();
	OpenDBConnection();
}

// You can define other methods, fields, classes and namespaces here
void OpenDBConnection()
{


	string cnString = @"data source='C:\Users\WR\AppData\Roaming\LINQPad\DemoDB.sdf'";

	using (var conn = new System.Data.SqlServerCe.SqlCeConnection(cnString))
	{
		conn.Open();

		conn.Dump();
		conn.Close();
 
	}
}