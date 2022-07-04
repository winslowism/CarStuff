namespace CarStuff.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }

        public virtual Address Address { get; set; } // maybe
        public virtual ICollection<CarPurchase> CarPurchases { get; set; }
    }
}
