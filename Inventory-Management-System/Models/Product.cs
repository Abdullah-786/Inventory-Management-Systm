using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Inventory_Management_System.Models
{
    //this is Product Model
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int Qty { get; set; }
    }
}
