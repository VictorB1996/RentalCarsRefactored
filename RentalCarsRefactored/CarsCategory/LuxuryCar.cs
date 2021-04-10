using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCarsRefactored.CarsCategory
{
    class LuxuryCar: ICar
    {
        public string Model { get; set; }
        public double basePrice { get; set; } = 70;
        public double additionalPrice { get; set; } = 0;

        public LuxuryCar(string model)
        {
            Model = model;
        }

        public double CalculatePrice(int daysRented, Customer customer, RentalCars office)
        {
            if(customer.FrequentRenterPoints < 3)
            {
                return 0;
            }
            
            double totalPrice = daysRented * basePrice;
            return totalPrice * office.PriceMultiplier;
        }
    }
}
