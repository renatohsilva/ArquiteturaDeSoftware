using DemoDI.Models;
using DemoDI.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class FromServicesController : Controller
    {
        public void Index([FromServices] IClienteServices clienteServices)
        {
            clienteServices.AdicionarCliente(new Cliente());
        }
    }
}
