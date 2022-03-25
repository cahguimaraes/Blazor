using System.ComponentModel.DataAnnotations;

namespace Blazor_Server_Project.Shared.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage =" Category Name is required")]
        [MaxLength(100)]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = " Category Description is required")]
        [MaxLength(200)]
        public string CategoryDescription { get; set; }

        public DateTime CategoryCreatedAt { get; set; }

        public ICollection<Product>? Products { get; set; }

    }
}
