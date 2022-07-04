namespace CarStuff.Models;

public class CarPurchase
{
    public int Id { get; set; }
    //public int CustomerId { get; set; }
    //public int SalesPersonId { get; set; }
    //public int CarId { get; set; }

    public DateTime OrderDate { get; set; }
    public float PricePaid { get; set; }

    public virtual Customer Customer { get; set; }
    public virtual Car Car { get; set; }
    public virtual SalesPerson SalesPerson { get; set; }
}