using DemoDI.Models;
using DemoDI.Repository.Interface;
using DemoDI.Service.Interface;

namespace DemoDI.Service
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteServices(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            return _clienteRepository.AdicionarCliente(cliente);
        }
    }
}
