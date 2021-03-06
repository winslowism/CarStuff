namespace CarStuff.Models;

public class Address
{
    public Address()
    {

    }

    public Address(string street, string houseNumber, string zipCode, string town, string country)
    {
        HouseNumber = houseNumber;
        Street = street;
        Town = town;
        ZipCode = zipCode;
        Country = country;
    }

    public int Id { get; set; }
    public string HouseNumber { get; set; }
    public string Street { get; set; }
    public string Town { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
}