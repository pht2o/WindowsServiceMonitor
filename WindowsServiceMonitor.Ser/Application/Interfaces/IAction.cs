namespace WindowsServiceMonitor.Ser.Application.Interfaces
{
    public interface IAction
    {
        void stop(int idService);
        void restart(int idService);
        void run(int idService);
    }
}
