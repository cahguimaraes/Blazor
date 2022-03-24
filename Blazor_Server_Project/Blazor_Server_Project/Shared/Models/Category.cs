using System.ComponentModel.DataAnnotations;

namespace Blazor_Server_Project.Shared.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [MaxLength(100)]
        public string CategoryName { get; set; }
        [MaxLength(200)]
        public string CategoryDescrtiption { get; set; }
        public DateTime CategoryCreatedAt { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
