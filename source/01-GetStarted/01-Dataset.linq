<Query Kind="Program">
  <Reference>&lt;ProgramFilesX86&gt;\Microsoft Visual Studio\Shared\Packages\Microsoft.SqlServer.Compact.4.0.8876.1\lib\net40\System.Data.SqlServerCe.dll</Reference>
  <Namespace>System.Data.SqlClient</Namespace>
  <Namespace>System.Data.SqlServerCe</Namespace>
  <Namespace>System.Numerics</Namespace>
</Query>

// LINQPad provides an easy way to get data context for a database
// this example bypasses the LINQPad system and uses basic ADO.NET
// Note:  since this is .NET core
// add System.Data.Common and System.Data.SqlClient nuget packages.
void Main()
{

	string cnString = @"data source='C:\Users\WR\AppData\Roaming\LINQPad\DemoDB.sdf'";


	using (var conn = new System.Data.SqlServerCe.SqlCeConnection(cnString))
	{
		conn.Open();

		var ds  =  GetDataSet (conn);
		
		ds.Dump();
		conn.Close();

	}

}


public DataSet GetDataSet(SqlCeConnection conn)
{
	var dataSet = new DataSet("NorthwindDemo");
	var shippersAdapter= new SqlCeDataAdapter("Select * From Shippers", conn);
	shippersAdapter.Fill(dataSet, "Shippers");
	var productsAdapter = new SqlCeDataAdapter("Select [Product Name],[Unit Price], [Units In Stock]From Products ", conn);
	productsAdapter.Fill(dataSet, "Products");
	
	
	return dataSet;

}
