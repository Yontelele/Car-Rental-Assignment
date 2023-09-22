using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Customer : IPerson
{
    public int SSN { get; init; }

    public string FirstName { get; init; }

    public string LastName { get; init; }

    public Customer(int ssn, string firstname, string lastname)
    {
        SSN = ssn;
        FirstName = firstname;
        LastName = lastname;
    }
}
