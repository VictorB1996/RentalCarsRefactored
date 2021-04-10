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
            Console.WriteLine($"Rental Records for {Name}\n");
            Console.WriteLine("------------------------------");

            foreach (var rental in _Rentals)
            {
                Console.WriteLine(rental.PrintCustomerRentDetails(this));
                totalRevenue += rental.Car.CalculatePrice(rental.DaysRented, rental.Customer, this);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Total Revenue {totalRevenue} EUR\n");
        }

        public void CarsCategoryRevenueReport()
        {

        }

    }
}
