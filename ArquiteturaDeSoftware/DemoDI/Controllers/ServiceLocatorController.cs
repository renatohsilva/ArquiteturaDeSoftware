using DemoDI.Models;
using DemoDI.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DemoDI.Controllers
{
    public class ServiceLocatorController : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public string? Index()
        {
            // Retorna null se não estiver registrado
            return _serviceProvider.GetRequiredService<IClienteServices>()?.AdicionarCliente(new Cliente("Renato"));
        }
    }
}
