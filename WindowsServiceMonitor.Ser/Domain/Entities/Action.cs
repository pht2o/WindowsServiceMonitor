using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsServiceMonitor.Ser.Domain.Entities
{
    [Table("ACTIONS")]
    public class Action
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(7)]
        public string Description { get; set; }
        [Required]
        [MaxLength(50)]
        public string Status { get; set; }
        public DateTime Register { get; set; }
        public int Id_Service { get; set; }
    }
}
