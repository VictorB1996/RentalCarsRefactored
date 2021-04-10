using System;
using System.Collections.Generic;
using System.Text;
using RentalCarsRefactored.CarsCategory;

namespace RentalCarsRefactored
{
    class Rental
    {
        public Customer Customer { get; }
        public ICar Car { get; }
        public int DaysRented { get; }

        public Rental(Customer customer, ICar car, int daysRented)
        {
            Customer = customer;
            Car = car;
            DaysRented = daysRented;
        }

        public string PrintCustomerRentDetails(RentalCars office)
        {
            string report = "";
            double FullPrice = Car.CalculatePrice(DaysRented, Customer, office);
            if (FullPrice != 0)
            {
                report += $"{Customer.Name}\t";
                report += $"{Car.Model}\t";
                report += $"{DaysRented}d\t";
                report += $"{FullPrice.ToString()} EUR";
            }
            else
            {
                return $"{Customer.Name} can not rent {Car.Model}.";
            }
            return report;
        }
    }
}
