using WindowsServiceMonitor.Ser.Application.Interfaces;
using WindowsServiceMonitor.Ser.Application.Services;


namespace WindowsServiceMonitor.Ser.Controllers
{
    public class AppController
    {
        private readonly IService _service;
        private readonly IServer _server;
        public AppController()
        {
            _service = new Service();
            _server = new ServerService();
        }

        public void GetAllMonitoredActivatedServices()
        {
            var listServices =  _service.GetAllServices();
            foreach (var service in listServices)
            {
                int IdServer = service.Id;
                if(IdServer > 0)
                {
                    var server = _server.GetById(IdServer);
                }
            }
        }
    }
}
