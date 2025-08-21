using System;

using WindowsServiceMonitor.Ser.Application.Interfaces;
using WindowsServiceMonitor.Ser.Application.Services;

namespace WindowsServiceMonitor.Ser
{
    public class Program
    {
        private readonly IService _service;
        public Program()
        {
            _service = new Service();
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
                    Console.WriteLine($"Service ID: {service.Id}, Name: {service.Id}, Status: {service.Enabled}");
                }
            }
            else
            {
                Console.WriteLine("No services found.");
            }
        }
    }
}
