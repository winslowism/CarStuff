namespace CarStuff.DAL.Interfaces
{
    // xx  https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design
    public interface IRepo<T>
    {
        public T Get(int id);
        public IQueryable<T> GetAll();
    }
}
