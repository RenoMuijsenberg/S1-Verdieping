using System;
using System.ComponentModel.DataAnnotations;

namespace DateReminder.Models
{
    public class ProductModel
    {
        //Id of product
        [Key]
        public int Id { get; set; }
        
        //Id of list
        public int ListId { get; set; }

        //Name of product
        [Required(ErrorMessage = "Product name is required")]
        public string ProductName { get; set; }

        //Image of product
        public string ProductImage { get; set; }

        //Date of product
        [Required(ErrorMessage = "Product date is required")]
        public DateTime ProductDate { get; set; }

        public int ProductCategory { get; set; }
    }
}
