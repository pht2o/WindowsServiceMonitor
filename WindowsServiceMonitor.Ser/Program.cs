using WindowsServiceMonitor.Ser.Controllers;

namespace WindowsServiceMonitor.Ser
{
    public class Program
    {
        private readonly AppController _app;
        Program()
        {
            _app = new AppController();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            _app.GetAllMonitoredActivetadServices();
        }
    }
}
