using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Motorcycle : IVehicle
{
    public string RegNo { get; init; }

    public string Make { get; init; }

    public int Odometer { get; init; }

    public double CostKm { get; init; }

    public string VehicleType { get; init; }

    public int CostDay { get; init; }

    public string Status { get; init; }

    public Motorcycle(string regno, string make, int odometer, double costkm, VehicleTypes vehicleTypes, int costday, VehicleStatus vehicleStatus)
    {
        RegNo = regno;
        Make = make;
        Odometer = odometer;
        CostKm = costkm;
        VehicleType = vehicleTypes.ToString();
        CostDay = costday;
        Status = vehicleStatus.ToString();
    }
}
