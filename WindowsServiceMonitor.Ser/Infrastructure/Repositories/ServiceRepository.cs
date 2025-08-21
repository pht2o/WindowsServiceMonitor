using System.Collections.Generic;
using System.Linq;

using WindowsServiceMonitor.Ser.Domain.Entities;
using WindowsServiceMonitor.Ser.Infrastructure.Data;

namespace WindowsServiceMonitor.Ser.Infrastructure.Repositories
{
    public class ServiceRepository
    {
        private readonly AppDbContext _context;
        public ServiceRepository()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Service> GetAllServices()
        {
            return _context.Services.Where(p => p.Enabled.ToLower() == "true").OrderBy(p => p.Id).ToList();
        }
    }
}
