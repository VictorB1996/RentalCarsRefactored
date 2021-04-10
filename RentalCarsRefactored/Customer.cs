using System;
using System.Collections.Generic;
using System.Text;
using RentalCarsRefactored.CarsCategory;

namespace RentalCarsRefactored
{
    class Customer
    {
        public string Name { get; }
        public int FrequentRenterPoints { get; set; } = 0;
        public List<Rental> Rentals { get; } = new List<Rental>();

        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental rental)
        {
            Rentals.Add(rental);

            if (rental.Car.GetType() == typeof(PremiumCar))
                FrequentRenterPoints++;
            FrequentRenterPoints++;
        }
    }
}
