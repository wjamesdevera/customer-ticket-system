using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace customer_ticket_system.Models
{
    [Table("tickets")]
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public User IssuedBy { get; set; }
        public User AssignedTo { get; set; }
        
        public Label Label { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
            
    }
}