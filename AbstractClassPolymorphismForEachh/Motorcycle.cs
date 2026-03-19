using System;
public class Motorcycle : Vehicle
{
    public int EngineCapacity { get; set; }
    public bool HasSidecar { get; set; }
    public string Type { get; set; }
    public string MotorcycleInfo { get; set; }

    public Motorcycle(string brand, string model, int year, string platenumber,
        double fuellevel, int maxspeed, int enginecapacity, bool hassidecar,
        string type, string motorcycleinfo)
        : base(brand, model, year, platenumber, fuellevel, maxspeed)
    {
        this.EngineCapacity = enginecapacity;
        this.HasSidecar = hassidecar;
        this.Type = type;
        this.MotorcycleInfo = motorcycleinfo;
    }

    public void ShowMotorcycleInfo()
    {
        ShowVehicleInfo();
        Console.WriteLine($"Engine Capacity: {EngineCapacity} cc, Has Sidecar: {HasSidecar}, Type: {Type}");
    }

    public double CalculateFuelCost(double distance)
    {
        return (distance / 100) * 4 * 1.50;
    }
}

