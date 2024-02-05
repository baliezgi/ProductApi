using ProductApi.Models.Categories;

namespace ProductApi.Models.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string? Description { get; set; }
        public string? Size { get; set; }
        public int CategoryId { get; set; }

        //NAvigation Property
        public Category Category { get; set; } = null!;


    }
}
