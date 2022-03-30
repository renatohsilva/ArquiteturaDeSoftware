using DemoDI.Service.Interface;

namespace DemoDI.Service
{
    public class ServiceA : IService
    {
        public string Retorno()
        {
            return "A";
        }
    }
}
