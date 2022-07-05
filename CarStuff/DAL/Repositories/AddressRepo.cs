using CarStuff.DAL.Interfaces;
using CarStuff.Models;

namespace CarStuff.DAL.Repositories
{
    public interface IAddressRepo : IRepo<Address>
    {
    }

    public class AddressRepo :  IAddressRepo
    {
        private readonly CarContext _ctx;

        public AddressRepo(CarContext ctx)
        {
            _ctx = ctx;
        }

        public Address Get(int id)
        {
            return _ctx.Addresses.FirstOrDefault(x => x.Id == id) ?? null;
        }

        public IQueryable<Address> GetAll()
        {
            return _ctx.Addresses;
        }
    }
}