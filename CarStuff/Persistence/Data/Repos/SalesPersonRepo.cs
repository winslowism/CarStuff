using CarStuff.Data;
using CarStuff.Models;
using CarStuff.Persistence.Data.Repos.Interfaces;

namespace CarStuff.Persistence.Data.Repos;

public class SalesPersonRepo // : IRepo<SalesPerson>, IAggregateRoot
{
    private readonly CarContext _ctx;

    public SalesPersonRepo(CarContext ctx)
    {
        _ctx = ctx;
    }

    public Task<SalesPerson> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<SalesPerson>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task Create(SalesPerson p)
    {
        throw new NotImplementedException();
    }

    public Task Update(SalesPerson p)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }
}