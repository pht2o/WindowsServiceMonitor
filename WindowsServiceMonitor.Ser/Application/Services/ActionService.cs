using WindowsServiceMonitor.Ser.Application.Interfaces;
using WindowsServiceMonitor.Ser.Infrastructure.Repositories;

namespace WindowsServiceMonitor.Ser.Application.Services
{
    internal class ActionService : IAction
    {
        private readonly ActionRepository _actionRepository;
        public ActionService()
        {
            _actionRepository = new ActionRepository();
        }
        public void stop(int idService)
        {
            _actionRepository.StopService(idService);
        }
        public void restart(int idService)
        {
            _actionRepository.RestartService(idService);
        }

        public void run(int idService)
        {
            _actionRepository.RunService(idService);
        }
    }
}
