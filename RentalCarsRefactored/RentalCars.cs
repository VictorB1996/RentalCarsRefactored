using System;
using System.Collections.Generic;
using System.Text;
using RentalCarsRefactored.CarsCategory;
using System.Linq;

namespace RentalCarsRefactored
{
    class RentalCars
    {
        public string Name { get; }
        public double PriceMultiplier { get; set; }

        private readonly List<Rental> _Rentals = new List<Rental>();

        public static Dictionary<string, double> RevenuePerCategory = new Dictionary<string, double>()
        {
            {"Regular", 0 },
            {"Mini", 0 },
            {"Premium", 0 },
            {"Luxury", 0 }
        };

        public RentalCars(string name, double priceMultiplier)
        {
            Name = name;
            PriceMultiplier = priceMultiplier;
        }

        public void AddRental(Rental rental)
        {
            _Rentals.Add(rental);
            rental.Customer.AddRental(rental);
        }

        public void CustomersReport()
        {
            double totalRevenue = 0;
            Console.WriteLine($"Rental Records for {Name}");
            Console.WriteLine("------------------------------");

            foreach (var rental in _Rentals)
            {
                Console.WriteLine(rental.PrintCustomerRentDetails(this));
                totalRevenue += rental.Car.CalculatePrice(rental.DaysRented, rental.Customer, this);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Total Revenue {totalRevenue} EUR\n");
        }

        public static void CarsCategoryRevenueReport()
        {
            Console.WriteLine("Revenue by Car Category");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Category\tTotal Income");
            foreach(KeyValuePair<string, double> keyValuePair in RevenuePerCategory)
            {
                Console.WriteLine($"{keyValuePair.Key}\t\t{keyValuePair.Value} EUR");
            }
        }

    }
}
