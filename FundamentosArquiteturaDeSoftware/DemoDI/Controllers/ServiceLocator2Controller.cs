using DemoDI.Models;
using DemoDI.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class ServiceLocator2Controller : Controller
    {
        public string? Index([FromServices] IServiceProvider serviceProvider)
        {
            // Retorna null se não estiver registrado
            return serviceProvider.GetRequiredService<IClienteServices>()?.AdicionarCliente(new Cliente("Renato"));
        }
    }
}
