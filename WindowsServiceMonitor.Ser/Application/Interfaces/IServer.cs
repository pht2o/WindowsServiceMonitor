using WindowsServiceMonitor.Ser.Domain.Entities;

namespace WindowsServiceMonitor.Ser.Application.Interfaces
{
    public interface IServer
    {
        Server GetById(int id);
    }
}
