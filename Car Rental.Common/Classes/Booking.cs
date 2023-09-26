using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes
{
    public class Booking : IBooking
    {
        public string RegNo { get; init; }

        public string Customer { get; init; }

        public int? KmReneted { get; init; }

        public int? KmReturned { get; init; }

        public string Reneted { get; init; }

        public string Returned { get; init; }

        public VehicleStatus VehicleStatus { get; init; }

        public int Days { get; init; }

        public int Km { get; init; }

        public double? Cost { get; set; }

        public void ReturnVehicle(IVehicle vehicle)
        {
            Cost = Days * vehicle.CostDay + Km * vehicle.CostKm;
        }

        public Booking(string regno, string customer, int? kmreneted, int? kmreturned, string reneted, string returned, double? cost, VehicleStatus vehicleStatus)
        {
            RegNo = regno;
            Customer = customer;
            KmReneted = kmreneted;
            KmReturned = kmreturned;
            Reneted = reneted;
            Returned = returned;
            Cost = cost;
            VehicleStatus = vehicleStatus;
        }
    }
}
