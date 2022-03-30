using DemoDI.Repository.Interface;

namespace DemoDI.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public string? Adicionar(T obj)
        {
            return obj?.ToString();
        }
    }
}
