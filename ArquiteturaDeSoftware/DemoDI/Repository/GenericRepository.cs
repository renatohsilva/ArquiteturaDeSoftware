using DemoDI.Repository.Interface;

namespace DemoDI.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Adicionar(T obj)
        {
            // Faz algo
        }
    }
}
