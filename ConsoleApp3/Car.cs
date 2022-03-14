using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Car : Vehicle
    {
        public double remaningfuel;
        public string Model;
        public string Brand;
        public double FuelCapacity;
        public double FuelFor1km;
        public double CurrentFuel;
        public double Drive;


        public Car(string model, string brand, double currentfuel, double drive, double fuelfor1km, double fuelcapacity, int year)

        {
           
           
            this.Model = model;
            Console.WriteLine(Model);
            this.Brand = brand;
            Console.WriteLine(Brand);
            this.CurrentFuel = currentfuel;
            Console.WriteLine(currentfuel);
            this.Drive = drive;
            Console.WriteLine(drive);
            this.FuelFor1km = fuelfor1km;
            Console.WriteLine(fuelfor1km);
            this.FuelCapacity = fuelcapacity;
            Console.WriteLine(FuelCapacity);
            this.Year = year;
            Console.WriteLine(year);
            Console.WriteLine("--------------------------");
            if (currentfuel / drive >= fuelfor1km)
            {
                remaningfuel = currentfuel - drive * fuelfor1km;
                Console.WriteLine(remaningfuel);
            }
            else
            {
                Console.WriteLine("ceninizde kifayet qeder benzin yoxdur");
            }

        }
       
          
    }
}
