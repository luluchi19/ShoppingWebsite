using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingWeb.Models
{
    public class RatingModel
    {
        [Key]
        public int Id { get; set; }

        public long ProductId { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập đánh giá Sản phẩm")]
        public string Comment { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập tên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập email")]
        public string Email { get; set; }

        public string Star { get; set; }

        [ForeignKey("ProductId")]
        public ProductModel Product { get; set; }

    }
}
