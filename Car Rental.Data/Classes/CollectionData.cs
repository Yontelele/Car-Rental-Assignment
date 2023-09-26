using Car_Rental.Common.Classes;
using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
using Car_Rental.Data.Interfaces;

namespace Car_Rental.Data.Classes;

public class CollectionData : IData
{
    readonly List<IPerson> _persons = new List<IPerson>();
    readonly List<IVehicle> _vehicles = new List<IVehicle>();
    readonly List<IBooking> _bookings = new List<IBooking>();

    public CollectionData()
    {
        SeedData();
    }

    void SeedData()
    {
        _persons.Add(new Customer(12345, "Joe", "Larsson"));
        _persons.Add(new Customer(98765, "Doe", "Larsson"));

        _vehicles.Add(new Car("ADC123", "Volvo", 10000, 1, VehicleTypes.Combi, 200, VehicleStatus.Available));
        _vehicles.Add(new Car("DEF456", "Saab", 20000, 1, VehicleTypes.Sedan, 100, VehicleStatus.Available));
        _vehicles.Add(new Car("GHI789", "Tesla", 1000, 3, VehicleTypes.Sedan, 100, VehicleStatus.Booked));
        _vehicles.Add(new Car("JKL012", "Jeep", 5000, 1.5, VehicleTypes.Van, 300, VehicleStatus.Available));
        _vehicles.Add(new Motorcycle("MNO234", "Yamaha", 30000, 0.5, VehicleTypes.Motorcycle, 50, VehicleStatus.Available));

        _bookings.Add(new Booking("GHI789", "Doe Larsson (98765)", 1000, null, "16/10/2023", "", null, VehicleStatus.Booked));
        _bookings.Add(new Booking("DEF456", "Joe Larsson (12345)", 20000, 21000, "10/10/2023", "11/10/2023", 1200, VehicleStatus.Available));
    }

    public IEnumerable<IPerson> GetPersons()
    {
        return _persons;
    }
    public IEnumerable<IVehicle> GetVehicles(VehicleStatus status = default)
    {
        return _vehicles;
    }
    public IEnumerable<IBooking> GetBookings()
    {
        return _bookings;
    }

}
