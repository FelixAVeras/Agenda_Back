using System.ComponentModel.DataAnnotations;

namespace AgendaMVC.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Dirección")]
        [StringLength(180, ErrorMessage = "El campo {0} no admite mas de {1} carácteres")]
        public string AddressDescription { get; set; }

        [Required]
        [Display(Name = "Cliente")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}