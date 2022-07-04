namespace CarStuff.Models
{
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(string firstName, string lastName, int age, DateTime created, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Created = created;
            Address = address;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }

        public virtual Address Address { get; set; } // maybe
        public virtual ICollection<CarPurchase> CarPurchases { get; set; }
    }
}
