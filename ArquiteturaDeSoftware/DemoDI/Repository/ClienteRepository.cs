using DemoDI.Models;
using DemoDI.Repository.Interface;

namespace DemoDI.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        public string AdicionarCliente(Cliente cliente)
        {
            return cliente.ToString();
        }
    }
}
