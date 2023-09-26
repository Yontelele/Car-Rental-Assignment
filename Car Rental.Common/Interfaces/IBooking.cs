using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IBooking
{
    public string RegNo { get; init; }

    public string Customer { get; init; }

    public int? KmReneted { get; init; }

    public int? KmReturned { get; init; }

    public string Reneted { get; init; }

    public string Returned { get; init; }

    public double? Cost { get; set; }

    public VehicleStatus VehicleStatus { get; init; }
}