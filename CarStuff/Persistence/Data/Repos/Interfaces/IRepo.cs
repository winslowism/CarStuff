namespace CarStuff.Persistence.Data.Repos.Interfaces
{
    // xx  https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design
    public interface IRepo<T> where T : IAggregateRoot
    {
        Task<T> Get(int id);
        Task<List<T>>  GetAll();
        Task Create(T p);
        Task Update(T p);
        Task Delete(int id);

    }
}
