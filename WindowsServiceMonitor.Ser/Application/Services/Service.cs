using System;
using System.Collections.Generic;

using WindowsServiceMonitor.Ser.Application.Interfaces;
using WindowsServiceMonitor.Ser.Infrastructure.Repositories;

namespace WindowsServiceMonitor.Ser.Application.Services
{
    public class Service : IService
    {
        private readonly ServiceRepository _serviceRepository;
        public Service()
        {
            _serviceRepository = new ServiceRepository();
        }

        public IEnumerable<Domain.Entities.Service> GetAllServices()
        {
            return _serviceRepository.GetAllServices();
        }
        void IService.Restart()
        {
            throw new NotImplementedException();
        }

        void IService.Start()
        {
            throw new NotImplementedException();
        }

        void IService.Stop()
        {
            throw new NotImplementedException();
        }
    }
}
