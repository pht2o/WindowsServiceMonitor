using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsServiceMonitor.Ser.Domain.Entities
{
    [Table("SERVERS")]
    public class Server
    {
        public int Id { get; set; }
        public string Adress { get; set; }
        public string Status { get; set; }
        public string Enabled { get; set; }
        public DateTime Register { get; set; }
    }
}
