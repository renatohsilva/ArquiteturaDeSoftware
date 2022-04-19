using DemoDI.Models;
using DemoDI.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class FromServicesController : Controller
    {
        public string Index([FromServices] IClienteServices clienteServices)
        {
            return clienteServices.AdicionarCliente(new Cliente("Renato"));
        }
    }
}
