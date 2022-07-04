namespace CarStuff.Models;

public class SalesPerson
{
    public int Id { get; set; }

    public string Name { get; set; }
    public float Salary { get; set; }

    public virtual Address? Address { get; set; }
}