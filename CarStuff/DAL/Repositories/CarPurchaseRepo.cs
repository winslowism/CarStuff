using CarStuff.DAL.Interfaces;
using CarStuff.Models;
using Microsoft.EntityFrameworkCore;

namespace CarStuff.DAL.Repositories
{
    public interface ICarPurchaseRepo : IRepo<CarPurchase>
    {
    }

    public class CarPurchaseRepo : ICarPurchaseRepo
    {
        private readonly CarContext _ctx;

        public CarPurchaseRepo(CarContext ctx)
        {
            _ctx = ctx;
        }

        public CarPurchase Get(int id)
        {
            return _ctx.CarPurchases.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<CarPurchase> GetAll()
        {
            return _ctx.CarPurchases
                .Include(x => x.Car)
                    .ThenInclude(x=> x.Extras)
                .Include(x => x.SalesPerson)
                    .ThenInclude(x=> x.Address)
                .Include(x => x.Customer)
                    .ThenInclude(x=> x.Address);
        }
    }
}
