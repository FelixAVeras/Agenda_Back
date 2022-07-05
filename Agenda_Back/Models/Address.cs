using System.ComponentModel.DataAnnotations;

namespace Agenda_Back.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        [Required]
        public string AddressDescription { get; set; }

        public virtual Customer Customer { get; set; }
    }
}