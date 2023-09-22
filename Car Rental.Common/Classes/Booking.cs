using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes
{
    public class Booking : IBooking
    {
        public int CostDay { get; private set; }
        public int days { get; private set; }
        public int km { get; private set; }
        public double Cost { get; private set; }

        void ReturnVehicle(IVehicle vehicle)
        {
            Cost = days * vehicle.CostDay + km * vehicle.CostKm;
        }

    }
}
