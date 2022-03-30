using DemoDI.Models;
using DemoDI.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class VidaRealController : Controller
    {
        private readonly IClienteServices _clienteServices;

        public VidaRealController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        public void Index()
        {
            _clienteServices.AdicionarCliente(new Cliente());
        }
    }
}
