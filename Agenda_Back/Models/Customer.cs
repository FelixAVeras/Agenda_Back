using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Agenda_Back.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public Address Address { get; set; }
    }
}