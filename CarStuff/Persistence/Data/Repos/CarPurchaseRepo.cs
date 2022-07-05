using CarStuff.Data;
using CarStuff.Models;
using CarStuff.Persistence.Data.Repos.Interfaces;

namespace CarStuff.Persistence.Data.Repos
{
    public class CarPurchaseRepo // : IRepo<CarPurchase> todo
    {
        private readonly CarContext _ctx;

        public CarPurchaseRepo(CarContext ctx)
        {
            _ctx = ctx;
        }

        public Task<CarPurchase> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CarPurchase>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Create(CarPurchase p)
        {
            throw new NotImplementedException();
        }

        public Task Update(CarPurchase p)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
