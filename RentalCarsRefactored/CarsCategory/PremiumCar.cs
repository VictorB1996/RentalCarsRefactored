using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCarsRefactored.CarsCategory
{
    class PremiumCar: ICar
    {
        public string Model { get; set; }
        public double basePrice { get; set; } = 30;
        public double additionalPrice { get; set; } = 0;

        public PremiumCar(string model)
        {
            Model = model;
        }

        public double CalculatePrice(int daysRented, Customer customer, RentalCars office)
        {
            double totalPrice = 0;

            if (daysRented > 2)
                totalPrice = basePrice * 2 + (daysRented - 2) * additionalPrice;
            else
                totalPrice = daysRented * basePrice;

            if (customer.FrequentRenterPoints >= 5)
                totalPrice *= 0.05;

            RentalCars.RevenuePerCategory["Premium"] += totalPrice * office.PriceMultiplier / 2;
            return totalPrice * office.PriceMultiplier;
        }
    }
}
