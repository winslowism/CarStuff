//using CarStuff.Models;

//namespace CarStuff.Data
//{
//    public static class DbInitializer
//    {
//        public static void Initialize(CarContext context)
//        {
//            // check customers
//            if (context.Customers.Any())
//            {
//                return;
//            }


//            //var Name = new ExtraItem[]
//            //{
//            //    new ExtraItem() {Name = Extra.Awesome},
//            //    new ExtraItem() {Name = Extra.Slow},
//            //    new ExtraItem() {Name = Extra.Loud},
//            //    new ExtraItem() {Name = Extra.ReallyFast},
//            //    new ExtraItem() {Name = Extra.Fast},
//            //};

//            //context.ExtraItems.AddRange(extra);
//            //context.SaveChanges();


//            var cars = new Car[]
//{
//            new Car(){Color = Color.Black, Extras = new List<ExtraItem>() { new(){Name = Extra.Awesome}}, Make = Make.Ford, Model = Model.Five, RecommendedPrice = 12},
//            new Car(){Color = Color.Blue, Extras = new List<ExtraItem>() { new(){Name = Extra.Awesome}, new(){Name = Extra.Fast}}, Make = Make.Ford, Model = Model.Four, RecommendedPrice = 1332},
//            new Car(){Color = Color.Blue, Extras = new List<ExtraItem>() { new(){Name = Extra.Awesome}, new(){Name = Extra.Loud}}, Make = Make.Hyundai, Model = Model.Three, RecommendedPrice = 1223},
//            new Car(){Color = Color.Blue, Extras = new List<ExtraItem>() { new(){Name = Extra.Loud}, new(){Name = Extra.Slow}}, Make = Make.Hyundai, Model = Model.One, RecommendedPrice = 142},
//            new Car(){Color = Color.Blue, Extras = new List<ExtraItem>() { new(){Name = Extra.Awesome}, new(){Name = Extra.Fast}}, Make = Make.Kia, Model = Model.Two, RecommendedPrice = 152},
//            new Car(){Color = Color.Blue, Extras = new List<ExtraItem>() { new(){Name = Extra.ReallyFast}}, Make = Make.Kia, Model = Model.One, RecommendedPrice = 127},
//            new Car(){Color = Color.Blue, Extras = new List<ExtraItem>() { new(){Name = Extra.Fast}, new(){Name = Extra.Awesome}}, Make = Make.Ford, Model = Model.Two, RecommendedPrice = 1252},
//            new Car(){Color = Color.Blue, Extras = new List<ExtraItem>() { new(){Name = Extra.Fast}, new(){Name = Extra.ReallyFast}}, Make = Make.Nissan, Model = Model.Two, RecommendedPrice = 182},
//            new Car(){Color = Color.Blue, Extras = new List<ExtraItem>() { new(){Name = Extra.Slow}, new(){Name = Extra.Fast}}, Make = Make.Nissan, Model = Model.Three, RecommendedPrice = 612},
//            new Car(){Color = Color.Blue, Extras = new List<ExtraItem>() { new(){Name = Extra.Awesome}, new(){Name = Extra.Slow}}, Make = Make.Hyundai, Model = Model.Two, RecommendedPrice = 1782},
//            new Car(){Color = Color.Blue, Extras = new List<ExtraItem>() { new(){Name = Extra.Awesome}, new(){Name = Extra.Fast}, new (){Name = Extra.ReallyFast}}, Make = Make.Kia, Model = Model.Four, RecommendedPrice = 122},
//};

//            foreach (var s in cars)
//            {
//                context.Cars.Add(s);
//            }
//            context.SaveChanges();

//            context.Cars.AddRange(cars);
//            context.SaveChanges();



//            var customers = new Customer[]
//            {
//            new Customer {FirstName="Carla", LastName="January", Age=20, Address = new Address() {Id = 0, Street = "bingo bango"}, Created = DateTime.Now,},
//            new Customer {FirstName="Carmen", LastName="Feb", Age=21, Address = new Address() {Street = "klosterport"}, Created = DateTime.Now.AddDays(-2),},
//            new Customer {FirstName="Carlos", LastName="March", Age=22, Address = new Address() {Street = "bingo bang0"}, Created = DateTime.Now.AddDays(-3),},
//            new Customer {FirstName="Ricardo", LastName="April", Age=23, Address = new Address() {Street = "graven"}, Created = DateTime.Now.AddDays(-4),},
//            new Customer {FirstName="Carl", LastName="June", Age=24, Address = new Address() {Street = "bingo"}, Created = DateTime.Now.AddDays(-17),},
//            new Customer {FirstName="Carsten", LastName="July", Age=23, Address = new Address() {Street = "bango"}, Created = DateTime.Now.AddDays(-7),},
//            };

//            context.Customers.AddRange(customers);
//            context.SaveChanges();



//            var salesPeople = new SalesPerson[]
//            {
//            new SalesPerson{Name = "Sally", Address = new Address(){HouseNumber = "12b"}, Salary = 132},
//            new SalesPerson{Name = "Sal", Address = new Address() {Country = "DK"}, Salary = 12},
//            new SalesPerson{Name = "Helga", Address = new Address() {ZipCode = "33028"}, Salary = 412}
//            };

//            context.SalesPeople.AddRange(salesPeople);
//            context.SaveChanges();

//            var carPurchases = new CarPurchase[]
//            {
//                new CarPurchase{CarId = 1, CustomerId = 3, SalesPersonId = 1},
//                new CarPurchase{CarId = 2, CustomerId = 4, SalesPersonId = 2},
//                new CarPurchase{CarId = 3, CustomerId = 3, SalesPersonId = 3},
//                new CarPurchase{CarId = 4, CustomerId = 6, SalesPersonId = 1},
//                new CarPurchase{CarId = 5, CustomerId = 2, SalesPersonId = 2},
//                new CarPurchase{CarId = 6, CustomerId = 1, SalesPersonId = 3},
//                new CarPurchase{CarId = 7, CustomerId = 4, SalesPersonId = 3},
//                new CarPurchase{CarId = 8, CustomerId = 6, SalesPersonId = 2},
//                new CarPurchase{CarId = 9, CustomerId = 5, SalesPersonId = 2},
//                new CarPurchase{CarId = 10, CustomerId = 2, SalesPersonId = 1},
//            };

//            context.CarPurchases.AddRange(carPurchases);
//            context.SaveChanges();
//        }
//    }
//}
