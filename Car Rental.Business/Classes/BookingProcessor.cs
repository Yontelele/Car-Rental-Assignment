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

    public IEnumerable<IPerson> GetCustomers()
    {
        return data.GetPersons();
    }

    public IEnumerable<IVehicle> GetVehicles(VehicleStatus status = default)
    {
        return data.GetVehicles();
    }

    public IEnumerable<IBooking> GetBookings()
    {
        return data.GetBookings();
    }
}
