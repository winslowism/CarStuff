using CarStuff.DAL.Interfaces;
using CarStuff.Models;

namespace CarStuff.DAL.Repositories
{
    public interface ICustomerRepo : IRepo<Customer>
    {
    }

    public class CustomerRepo : ICustomerRepo
    {
        private readonly CarContext _ctx;

        public CustomerRepo(CarContext ctx)
        {
            _ctx = ctx;
        }

        public Customer Get(int id)
        {
            return _ctx.Customers.FirstOrDefault(x => x.Id == id) ?? null;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _ctx.Customers;
        }
    }
}
