namespace ProductApi.Models.DTOs
{
    public class ProductAddDtoRequest
    {
        public string Name { get; set; } = null!;
        public int Price { get; set; }
    }
}
