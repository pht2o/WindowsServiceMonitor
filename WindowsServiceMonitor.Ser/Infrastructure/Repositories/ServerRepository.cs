using WindowsServiceMonitor.Ser.Infrastructure.Data;

namespace WindowsServiceMonitor.Ser.Infrastructure.Repositories
{
    public class ServerRepository
    {
        private readonly AppDbContext _context;
        public ServerRepository()
        {
            _context = new AppDbContext();
        }
        public Domain.Entities.Server GetById(int id)
        {
            return _context.Servers.Find(id);
        }
    }
}
