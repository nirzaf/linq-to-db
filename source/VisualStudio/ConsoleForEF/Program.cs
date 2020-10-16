using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForEF
{
	class Program
	{
		static void Main(string[] args)
		{
			// get the Entity Framework (EF) data context
			// using the default connection defined in the app.config file
			var context = new NorthwindEntities();

			// work with the EF model classes

			var shipper = context.Shippers.First();

			Console.WriteLine(shipper.CompanyName);

			var products = from p in context.Products
										 where p.UnitPrice < 20
										 select new { p.ProductName, p.UnitPrice };

			foreach (var product in products)
			{
				Console.WriteLine(product.ProductName);
			}
			
			
		}
	}
}
