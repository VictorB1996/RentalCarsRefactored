using System;
using RentalCarsRefactored.CarsCategory;

namespace RentalCarsRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalCars IasiRentals = new RentalCars("Iasi Rentals", 1);
            RentalCars BucharestRentals = new RentalCars("Bucuresti Rentals", 1.5);

            var customer1 = new Customer("Ion Popescu");
            var customer2 = new Customer("Mihai Chirica");
            var customer3 = new Customer("Gigi Becali");

            IasiRentals.AddRental(new Rental(customer1, new MiniCar("Mini"), 3));
            IasiRentals.AddRental(new Rental(customer2, new PremiumCar("Volvo"), 5));
            IasiRentals.AddRental(new Rental(customer3, new LuxuryCar("BMW"), 1));
            IasiRentals.CustomersReport();

            BucharestRentals.AddRental(new Rental(customer1, new MiniCar("Mini"), 3));
            BucharestRentals.AddRental(new Rental(customer2, new PremiumCar("Volvo"), 5));
            BucharestRentals.AddRental(new Rental(customer3, new LuxuryCar("BMW"), 1));
            BucharestRentals.CustomersReport();



        }
    }
}
