namespace DemoDI.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        string? Adicionar(T obj);
    }
}
