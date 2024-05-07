using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Inventory_Management_System.Models
{
    public class Sales
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Qty { get; set; }
    }
}
