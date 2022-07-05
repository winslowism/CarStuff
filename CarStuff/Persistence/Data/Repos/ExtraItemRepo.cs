using CarStuff.Data;
using CarStuff.Models;
using CarStuff.Persistence.Data.Repos.Interfaces;

namespace CarStuff.Persistence.Data.Repos;

public class ExtraItemRepo // : IRepo<ExtraItem>, IAggregateRoot
{
    private readonly CarContext _ctx;

    public ExtraItemRepo(CarContext ctx)
    {
        _ctx = ctx;
    }

    public Task Create(ExtraItem p)
    {
        throw new NotImplementedException();
    }

    public Task Update(ExtraItem p)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }

    Task<ExtraItem> Get(int id)
    {
        throw new NotImplementedException();
    }
}