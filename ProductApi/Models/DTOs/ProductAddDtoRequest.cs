using System.ComponentModel.DataAnnotations;

namespace ProductApi.Models.DTOs
{
    public class ProductAddDtoRequest
    {
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Ürün adı 3 ile 10 karakter arasında olmalıdır.")]
        [Required(ErrorMessage = "Ürün adı boş geçilemez!")]
        public string Name { get; set; } = null!;


        [Range(10, 100, ErrorMessage = "Ürün fiyatı 10 ile 100 arasında olmalıdır.")]
        [Required(ErrorMessage = "Ürün fiyatı boş geçilemez!")]
        public decimal? Price { get; set; }
    }
}
