<Query Kind="Statements">
  <Connection>
    <ID>54bf9502-9daf-4093-88e8-7177c129999f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Provider>System.Data.SqlServerCe.4.0</Provider>
    <AttachFileName>&lt;ApplicationData&gt;\LINQPad\DemoDB.sdf</AttachFileName>
    <Persist>true</Persist>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
  </Connection>
  <Reference Relative="..\..\..\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll">C:\Users\WR\Source\Repos\linq-2833070\source\VisualStudio\CourseLib\bin\Debug\netstandard2.0\CourseLib.dll</Reference>
</Query>

// when compiling a where clause
// the compiler can create an anonymous method
// or a Expression tree


// LINQ to object uses the anonymous method
// Uses the Enumerable.Where
var numbers = new List<Int32> { 3, 5, 7, 9, 2, 4, 6, 20, 40, 90, 100, 200 };
var q =	 from n in numbers
	 				where n < 20
	 				select n;

q.Dump("Linq to Objects query");
q.GetType().Dump("Linq to Objects, type");

// LINQ to SQL creates an expression tree
// Uses the Queryable.Where

var q2 = from p in Products
				 where p.UnitPrice > 100
				 select new {p.ProductName, p.UnitPrice};

q2.Dump("Linq to SQL, query");
q2.GetType().Dump();