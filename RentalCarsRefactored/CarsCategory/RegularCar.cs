using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCarsRefactored.CarsCategory
{
    class RegularCar : ICar
    {
        public string Model { get; set; }
        public double basePrice { get; set; } = 20;
        public double additionalPrice { get; set; } = 15;

        public RegularCar(string model)
        {
            Model = model;
        }

        public double CalculatePrice(int daysRented, Customer customer, RentalCars office)
        {
            double totalPrice = 0;

            if(daysRented > 2)
                totalPrice += basePrice * 2 + (daysRented - 2) * additionalPrice;
            else
                totalPrice += daysRented * basePrice;

            if (customer.FrequentRenterPoints >= 5)
                totalPrice *= 0.05;
            return totalPrice * office.PriceMultiplier;
        }
    }
}
