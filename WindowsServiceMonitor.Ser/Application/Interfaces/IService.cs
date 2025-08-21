using System.Collections.Generic;

using WindowsServiceMonitor.Ser.Domain.Entities;

namespace WindowsServiceMonitor.Ser.Application.Interfaces
{
    public interface IService
    {
        void Start();
        void Stop();
        void Restart();
        IEnumerable<Service> GetAllServices();
    }
}
