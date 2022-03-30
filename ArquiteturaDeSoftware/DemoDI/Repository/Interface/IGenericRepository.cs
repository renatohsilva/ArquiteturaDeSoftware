namespace DemoDI.Repository.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        void Adicionar(T obj);
    }
}
