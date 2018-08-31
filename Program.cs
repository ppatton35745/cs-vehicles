using System;
using System.Linq;
using System.Collections.Generic;


public interface IVehicle
{
    int PassengerCapacity { get; set; }
    string TransmissionType { get; set; }
    double EngineVolume { get; set; }
    void Start();
    void Stop();
}

public interface IAirVehicle : IVehicle
{
    int Doors { get; set; }
    int Wheels { get; set; }
    bool FixedWing { get; set; }

    double MaxAirSpeed { get; set; }
    void Fly();
}

public interface IWaterVehicle : IVehicle
{
    double MaxWaterSpeed { get; set; }
    void Drive();
}

public interface IGroundVehicle : IVehicle
{
    int Doors { get; set; }
    int Wheels { get; set; }

    double MaxLandSpeed { get; set; }
    void Drive();
}

public class WaterVehicle
{
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; }
    public double EngineVolume { get; set; }
    public double MaxWaterSpeed { get; set; }

    public WaterVehicle(int PassengerCapacity, string TransmissionType, double EngineVolume, double MaxWaterSpeed)
    {
        this.PassengerCapacity = PassengerCapacity;
        this.TransmissionType = TransmissionType;
        this.EngineVolume = EngineVolume;
        this.MaxWaterSpeed = MaxWaterSpeed;
    }
}
public class JetSki : WaterVehicle, IVehicle, IWaterVehicle
{

    public JetSki(int PassengerCapacity, string TransmissionType, double EngineVolume, double MaxWaterSpeed) : base(PassengerCapacity, TransmissionType, EngineVolume, MaxWaterSpeed)
    { }

    public void Drive()
    {
        Console.WriteLine("The jetski zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        Console.WriteLine("JetSki has been started");
    }

    public void Stop()
    {
        Console.WriteLine("Jetski has been stopped");
    }
}

public class Pontoon : WaterVehicle, IVehicle, IWaterVehicle
{
    public Pontoon(int PassengerCapacity, string TransmissionType, double EngineVolume, double MaxWaterSpeed) : base(PassengerCapacity, TransmissionType, EngineVolume, MaxWaterSpeed)
    { }

    public void Drive()
    {
        Console.WriteLine("The Pontoon zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        Console.WriteLine("Pontoon has been started");
    }

    public void Stop()
    {
        Console.WriteLine("Pontoon has been stopped");
    }
}

public class MasterCraft : WaterVehicle, IVehicle, IWaterVehicle
{
    public MasterCraft(int PassengerCapacity, string TransmissionType, double EngineVolume, double MaxWaterSpeed) : base(PassengerCapacity, TransmissionType, EngineVolume, MaxWaterSpeed)
    { }

    public void Drive()
    {
        Console.WriteLine("The MasterCraft zips through the waves with the greatest of ease");
    }

    public void Start()
    {
        Console.WriteLine("MasterCraft has been started");
    }

    public void Stop()
    {
        Console.WriteLine("MasterCraft has been stopped");
    }
}

public class Motorcycle : IVehicle
{
    public int Wheels { get; set; } = 2;
    public int Doors { get; set; } = 0;
    public int PassengerCapacity { get; set; }
    public string TransmissionType { get; set; } = "Manual";
    public double EngineVolume { get; set; } = 1.3;
    public double MaxLandSpeed { get; set; } = 160.4;

    public void Drive()
    {
        Console.WriteLine("The motorcycle screams down the highway");
    }

    public void Start()
    {
        Console.WriteLine("MotorCycle has been started");
    }

    public void Stop()
    {
        Console.WriteLine("MotorCycle has been stopped");
    }
}

public class Cessna : IVehicle
{
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 113;
    public bool FixedWing { get; set; } = true;
    public string TransmissionType { get; set; } = "None";
    public double EngineVolume { get; set; } = 31.1;
    public double MaxAirSpeed { get; set; } = 309.0;

    public void Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        Console.WriteLine("Cessna has been started");
    }

    public void Stop()
    {
        Console.WriteLine("Cessna has been stopped");
    }
}


public class Program
{

    public static void Main()
    {

        List<IWaterVehicle> waterVehicles = new List<IWaterVehicle>();

        MasterCraft myBoat = new MasterCraft(10, "good transmission", 68.0, 87.0);
        Pontoon mySlowBoat = new Pontoon(16, "old transmission", 44.0, 13.0);
        JetSki mySpeedBoat = new JetSki(2, "awesome transmission", 30.0, 100.99);

        waterVehicles.Add(myBoat);
        waterVehicles.Add(mySlowBoat);
        waterVehicles.Add(mySpeedBoat);

        waterVehicles.ForEach(vehicle =>
        {
            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();
        });
        // Build a collection of all vehicles that fly

        // With a single `foreach`, have each vehicle Fly()



        // Build a collection of all vehicles that operate on roads

        // With a single `foreach`, have each road vehicle Drive()



        // Build a collection of all vehicles that operate on water

        // With a single `foreach`, have each water vehicle Drive()
    }

}