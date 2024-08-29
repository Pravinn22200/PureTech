using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PureTech.Models
{
    public class Product
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Precision(16,2)]
        public decimal Price { get; set; }

        [StringLength(200)]
        public string Description { get; set; } = "";


        public string ImageFileName { get; set; } = "";


    }
}
