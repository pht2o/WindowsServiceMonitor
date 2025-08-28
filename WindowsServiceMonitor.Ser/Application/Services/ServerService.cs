using WindowsServiceMonitor.Ser.Application.Interfaces;
using WindowsServiceMonitor.Ser.Domain.Entities;
using WindowsServiceMonitor.Ser.Infrastructure.Repositories;

namespace WindowsServiceMonitor.Ser.Application.Services
{
    internal class ServerService : IServer
    {
        private readonly ServerRepository _serverRepository;
        public ServerService()
        {
            _serverRepository = new ServerRepository();
        }
        public Server GetById(int id)
        {
            return _serverRepository.GetById(id);
        }
    }
}
