using System;
using _17._03;
using System.Reflection;

class Car : Vehicle
{
    private double _fuelCapacity;
    private double _fuel;

    public double FuelCapacity
    {
        get { return _fuelCapacity; }
        set
        {
            if (value > 0)
                _fuelCapacity = value;
        }
    }

    public double Fuel
    {
        get { return _fuel; }
        set
        {
            if (value >= 0 && value <= FuelCapacity)
                _fuel = value;
        }
    }

    public double FuelConsumptionPer100Km;

    // Constructor
    public Car(string brand, string model, int year, double fuelCapacity, double fuelConsumption, double fuel):base(brand,model,year)
    {
        Brand = brand;
        Model = model;
        Year = year;

        FuelCapacity = fuelCapacity;
        FuelConsumptionPer100Km = fuelConsumption;

        if (fuel <= fuelCapacity)
            Fuel = fuel;
    }

    // Yanacaq doldurma
    public void Refuel(double liters)
    {
        if (Fuel + liters <= FuelCapacity)
        {
            Fuel += liters;
            Console.WriteLine($"{liters}L yanacaq əlavə olundu.");
        }
        else
        {
            Console.WriteLine("Yanacaq çəni doludur və ya çox əlavə etdiniz!");
        }
    }

    // Override Drive
    public override void Drive(int km)
    {
        if (!IsRunning)
        {
            Console.WriteLine("Mühərrik işləmir!");
            return;
        }

        double requiredLiters = (km / 100.0) * FuelConsumptionPer100Km;

        if (Fuel >= requiredLiters)
        {
            Fuel -= requiredLiters;
            MileageKm += km;
            Console.WriteLine($"{km} km sürüldü. {requiredLiters:F2}L yanacaq sərf olundu.");
        }
        else
        {
            Console.WriteLine("Kifayət qədər yanacaq yoxdur!");
        }
    }

    // Override VehicleInfo
    public void VehicleInfo()
    {
        Console.WriteLine($"Fuel: {Fuel}L / {FuelCapacity}L");
    }
}

