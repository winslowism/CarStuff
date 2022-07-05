using CarStuff.Data;
using CarStuff.Models;
using CarStuff.Persistence.Data.Repos.Interfaces;

namespace CarStuff.Persistence.Data.Repos
{
    public class CustomerRepo // : IRepo<Customer>, IAggregateRoot
    {
        private readonly CarContext _ctx;

        public CustomerRepo(CarContext ctx)
        {
            _ctx = ctx;
        }

        public Task<Customer> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Create(Customer p)
        {
            throw new NotImplementedException();
        }

        public Task Update(Customer p)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
