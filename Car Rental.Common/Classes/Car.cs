﻿using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Car : IVehicle
{
    public string RegNo { get; init; }

    public string Make { get; init; }

    public int Odometer { get; init; }

    public double CostKm { get; init; }

    public VehicleTypes VehicleTypes { get; init; }

    public int CostDay { get; init; }

    public VehicleStatus VehicleStatus { get; init; }

    public Car(string regno, string make, int odometer, double costkm, VehicleTypes vehicleTypes, int costday, VehicleStatus vehicleStatus)
    {
        RegNo = regno;
        Make = make;
        Odometer = odometer;
        CostKm = costkm;
        VehicleTypes = vehicleTypes;
        CostDay = costday;
        VehicleStatus = vehicleStatus;
    }
}
