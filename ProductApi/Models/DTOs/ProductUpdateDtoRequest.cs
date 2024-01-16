namespace ProductApi.Models.DTOs
{
    public class ProductUpdateDtoRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Price { get; set; }
    }
}
