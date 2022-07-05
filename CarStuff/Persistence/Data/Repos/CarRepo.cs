using CarStuff.Persistence.Data.Repos.Interfaces;

namespace CarStuff.Persistence.Data.Repos;

public class Car //: IRepo<Car>, IAggregateRoot
{
    public Task<Car> Get(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Car>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task Create(Car p)
    {
        throw new NotImplementedException();
    }

    public Task Update(Car p)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int id)
    {
        throw new NotImplementedException();
    }
}