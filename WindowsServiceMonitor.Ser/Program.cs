using System;

using WindowsServiceMonitor.Ser.Application.Interfaces;
using WindowsServiceMonitor.Ser.Application.Services;

namespace WindowsServiceMonitor.Ser
{
    public class Program
    {
        private readonly IService _service;
        private readonly IAction _action;
        public Program()
        {
            _service = new Service();
            _action = new ActionService();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            var listServices = _service.GetAllServices();
            if (listServices != null)
            {
                foreach (var service in listServices)
                {
                    Console.WriteLine($"Service ID: {service.Id}, Name: {service.Description}, Status: {service.Enabled}");

                    _action.run(service.Id);
                }

            }
            else
            {
                Console.WriteLine("No services found.");
            }
        }
    }
}
