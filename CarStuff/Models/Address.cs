﻿namespace CarStuff.Models;

public class Address
{
    public int Id { get; set; }
    public string HouseNumber { get; set; }
    public string Street { get; set; }
    public string Town { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
}