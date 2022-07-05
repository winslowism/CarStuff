using CarStuff.DAL.Interfaces;
using CarStuff.Models;

namespace CarStuff.DAL.Repositories
{
    public interface ISalesPersonRepo : IRepo<SalesPerson>
    {
    }

    public class SalesPersonRepo : ISalesPersonRepo
    {
        private readonly CarContext _ctx;

        public SalesPersonRepo(CarContext ctx)
        {
            _ctx = ctx;
        }

        public SalesPerson Get(int id)
        {
            return _ctx.SalesPeople.FirstOrDefault(x => x.Id == id) ?? null; 
        }

        public IEnumerable<SalesPerson> GetAll()
        {
            return _ctx.SalesPeople;
        }
    }
}