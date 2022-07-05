using System.ComponentModel.DataAnnotations;
using CarStuff.DAL;
using CarStuff.Extensions;
using CarStuff.Models;
using Microsoft.EntityFrameworkCore;

namespace CarStuff.Data
{
    public class DbInitializer
    {
        private CarContext _ctx { get; }

        public DbInitializer(CarContext ctx)
        {
            this._ctx = ctx;
        }

        public List<ExtraItem> GetRandomExtras()
        {
            var rnd = new Random();
            var extras = _ctx.Extras
                .ToList()
                .OrderBy(x => rnd.Next())
                .Take(rnd.Next(_ctx.Extras.Count()))
                .ToList();
            return extras;
        }

        public Model RandomModel() => new Random().NextEnum<Model>();
        public Make RandomMake() => new Random().NextEnum<Make>();
        public Color RandomColor() => new Random().NextEnum<Color>();
        public int RandomPrice() => new Random().Next(1000, 40000);

        public void Initialize()
        {
            // check customers
            if (_ctx.Customers.Any())
            {
                return;
            }

            AddExtras();
            AddCars(30);
            AddCustomers();
            AddSalesPeople();
            AddCarPurchases();
        }

        private void AddCarPurchases()
        {
            var startDate = new DateTime(2000, 1, 1);
            var endDate = DateTime.Now;
            var rnd = new Random();
            foreach (var car in _ctx.Cars)
            {
                var random = rnd.Next();
                var random2 = rnd.Next();
                var purchase = new CarPurchase()
                {
                    Car = car,
                    Customer = _ctx.Customers.OrderBy(x => random).First(),
                    SalesPerson = _ctx.SalesPeople.OrderBy(x => random2).First(),
                    OrderDate = startDate.RandomBetween(endDate),
                    PricePaid = GetPricePaid(car.RecommendedPrice)
                };
                _ctx.CarPurchases.Add(purchase);
            }

            _ctx.SaveChanges();
        }

        private float GetPricePaid(float recommended)
        {
            var rnd = new Random();
            return rnd.Next(1, 2) == 1 
                ? recommended + rnd.Next(4000) 
                : recommended - rnd.Next(4000);
        }

        private void AddSalesPeople()
        {
            var salesPeople = new SalesPerson[]
            {
                new SalesPerson {
                    Name = "Sally",
                    Address = new Address("Løkkegade", "1", "9000", "Aalborg", "Denmark"),
                    Salary = 132
                },
                new SalesPerson {
                    Name = "Sal",
                    Address = new Address("Løkkegade", "1", "9000", "Aalborg", "Denmark"),
                    Salary = 300
                },
                new SalesPerson {
                    Name = "Helga",
                    Address = new Address("Vestergade", "40", "8000", "Aarhus", "Denmark"),
                    Salary = 132
                }
            };

            _ctx.SalesPeople.AddRange(salesPeople);
            _ctx.SaveChanges();
        }

        private void AddCustomers()
        {
            var customers = new Customer[]
            {
                new Customer("Carla", "Smith", 20, DateTime.Now,
                    new Address("BingoGade", "20", "8000", "Aarhus", "Denmark")),
                new Customer("Max", "Mustermann", 19, DateTime.Now,
                    new Address("Hauptstrasse", "15", "21614", "Buxtehude", "Germany")),
                new Customer("Jens", "Møller", 20, DateTime.Now,
                    new Address("Banegade", "20", "8000", "Aarhus", "Denmark")),
                new Customer("Kathrine", "The Great", 34, DateTime.Now,
                    new Address("BingoGade", "8", "9100", "Aalborg", "Denmark")),
                new Customer("Stephan", "Johannson", 22, DateTime.Now,
                    new Address("Klostergade", "3", "9000", "Aalborg", "Denmark")),
                new Customer("Anders", "Nielsen", 54, DateTime.Now,
                    new Address("Klostergade", "10", "8000", "Aarhus", "Denmark")),
                new Customer("Louisa", "Encanto", 20, DateTime.Now,
                    new Address("BingoGade", "20", "8000", "Aarhus", "Denmark")),
                new Customer("Anette", "Kingsley", 30, DateTime.Now,
                    new Address("Løkkegade", "20", "9000", "Aalborg", "Denmark")),
                new Customer("Tim", "Lee", 33, DateTime.Now,
                    new Address("BingoGade", "99", "8000", "Aarhus", "Denmark")),

            };

            _ctx.Customers.AddRange(customers);
            _ctx.SaveChanges();
        }

        private void AddCars(int amount)
        {
            var cars = Enumerable.Range(0, amount)
                .Select(x => new Car()
                {
                    Color = RandomColor(),
                    Extras = GetRandomExtras(),
                    Make = RandomMake(),
                    Model = RandomModel(),
                    RecommendedPrice = RandomPrice()
                }).ToList();

            _ctx.Cars.AddRange(cars);
            _ctx.SaveChanges();
        }

        private void AddExtras()
        {
            var extras = new ExtraItem[]
            {
                new ExtraItem() {Name = Extra.Awesome},
                new ExtraItem() {Name = Extra.Slow},
                new ExtraItem() {Name = Extra.Loud},
                new ExtraItem() {Name = Extra.ReallyFast},
                new ExtraItem() {Name = Extra.Fast},
            };

            _ctx.Extras.AddRange(extras);
            _ctx.SaveChanges();
        }
    }
}
