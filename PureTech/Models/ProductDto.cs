using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PureTech.Models
{
    public class ProductDto
    {
       
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required, MaxLength(200)]
        public string Description { get; set; } = "";


        public IFormFile? ImageFile { get; set; }


    }
}