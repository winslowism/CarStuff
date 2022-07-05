using CarStuff.Data;
using CarStuff.Models;
using CarStuff.Persistence.Data.Repos.Interfaces;

namespace CarStuff.Persistence.Data.Repos
{
    public class AddressRepo // : IRepo<Address>, IAggregateRoot todo
    {
        private readonly CarContext _ctx;

        public AddressRepo(CarContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Address> Get(int id)
        {
            throw new NotImplementedException();
            //return await _ctx.Addresses.FindAsync(id) ?? new Address();
        }
         
        public async Task<List<Address>> GetAll()
        {
            throw new NotImplementedException();
            //return await _ctx.Addresses;
        }

        public Task Create(Address p)
        {
            throw new NotImplementedException();
        }

        public Task Update(Address p)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}