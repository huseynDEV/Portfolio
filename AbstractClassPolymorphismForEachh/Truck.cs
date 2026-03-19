using System;
public class Truck : Vehicle
{
    public double CargoCapacity { get; set; }
    public int AxleCount { get; set; }
    public double CurrentLoad { get; set; }

    public Truck(string brand, string model, int year, string platenumber,
        double fuellevel, int maxspeed, double cargocapacity, int axlecount, double currentload)
        : base(brand, model, year, platenumber, fuellevel, maxspeed)
    {
        this.CargoCapacity = cargocapacity;
        this.AxleCount = axlecount;
        this.CurrentLoad = currentload;
    }

    public void ShowTruckInfo()
    {
        ShowVehicleInfo();
        Console.WriteLine($"Cargo Capacity: {CargoCapacity} tons, Axle Count: {AxleCount}, Current Load: {CurrentLoad} tons");
    }

    public void LoadCargo(double weight)
    {
        if (CurrentLoad + weight <= CargoCapacity)
        {
            CurrentLoad += weight;
            Console.WriteLine("Yük qoyuldu");
        }
        else
        {
            Console.WriteLine("Tutum heddinden coxdur");
        }
    }

    public double CalculateFuelCost(double distance)
    {
        return (distance / 100) * (25 + CurrentLoad * 2) * 1.8;
    }
}
