using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Business.Classes;

public class BookingProcessor
{
    private readonly IData data;

    public BookingProcessor(IData data)
    {
        this.data = data;
    }


    // Logik
    public IEnumerable<Customer> GetCustomers()
    {

    }

    public IEnumerable<IVehicle> GetVehicles(VehicleStatus status = default)
    {

    }

    public IEnumerable<IBooking> GetBookings()
    {

    }
}
