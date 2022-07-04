using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Agenda_Back.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        [Required]
        public string AddressDescription { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}