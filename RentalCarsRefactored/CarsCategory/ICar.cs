using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCarsRefactored.CarsCategory
{
    interface ICar
    {
        string Model { get; set; }
        double basePrice { get; set; }
        double additionalPrice { get; set; }

        double CalculatePrice(int daysRented, Customer customer, RentalCars office);
    }
}
