using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgendaMVC.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(20, ErrorMessage = "El campo {0} no admite mas de {1} carácteres")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        [StringLength(20, ErrorMessage = "El campo {0} no admite mas de {1} carácteres")]
        public string LastName { get; set; }

        [Display(Name = "Nombre Completo")]
        public string FullName => $"{FirstName} {LastName}";

        public virtual ICollection<Address> Addresses { get; set; }
    }
}