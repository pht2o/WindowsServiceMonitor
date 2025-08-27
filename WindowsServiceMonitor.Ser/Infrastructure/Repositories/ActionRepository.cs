using System;

using WindowsServiceMonitor.Ser.Infrastructure.Data;
namespace WindowsServiceMonitor.Ser.Infrastructure.Repositories
{
    internal class ActionRepository
    {
        private readonly AppDbContext _context;

        public ActionRepository()
        {
            _context = new AppDbContext();
        }
        public void StopService(int serviceId)
        {
            Domain.Entities.Action Action = new Domain.Entities.Action
            {
                Description = "STOP",
                Status = "WAITING",
                Id_Service = serviceId,
                Register = DateTime.Now

            };
            _context.Action.Add(Action);
            _context.SaveChanges();
        }
        public void RestartService(int serviceId)
        {
            Domain.Entities.Action Action = new Domain.Entities.Action
            {
                Description = "RESTART",
                Status = "WAITING",
                Id_Service = serviceId,
                Register = DateTime.Now

            };
            _context.Action.Add(Action);
            _context.SaveChanges();
        }
        public void RunService(int serviceId)
        {
            Domain.Entities.Action Action = new Domain.Entities.Action
            {
                Description = "RUN",
                Status = "WAITING",
                Id_Service = serviceId,
                Register = DateTime.Now

            };
            _context.Action.Add(Action);
            _context.SaveChanges();
        }
    }
}
