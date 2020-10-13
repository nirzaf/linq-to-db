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
			var context = new ToursEntities();

			// work with the EF model classes

			var testimonial = context.Testimonials.First();

			Console.WriteLine(testimonial.Comment);

			var tours = from t in context.Tours
									orderby t.MaxPeoplePerTour
									select new { t.TourName, t.Description, t.MaxPeoplePerTour };

			foreach (var tour in tours)
			{
				Console.WriteLine(tour.TourName);
			}

		}
	}
}
