using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ShoppingWeb.Models
{
    public class WishlistModel
    {
        [Key]
        public int Id { get; set; }

        public long ProductId { get; set; }

        public string UserId { get; set; }

        [ForeignKey("ProductId")]
        public ProductModel Product { get; set; }
    }
}
