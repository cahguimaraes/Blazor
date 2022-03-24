using System.ComponentModel.DataAnnotations;

namespace Blazor_Server_Project.Shared.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [MaxLength(100)]
        public string ProductName { get; set; }
        [MaxLength(200)]
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        [MaxLength(250)]
        public string ProductImageUrl { get; set; }

        //indica o relacionamento
        public int CategoryId { get; set; }
        // prop de navegação
        public virtual Category Category { get; set; }
    }
}
