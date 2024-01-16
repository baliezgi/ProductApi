namespace ProductApi.Models.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> Products = new();

        public ProductRepository()
        {
            if (Products.Count == 0)
            {
                Products.Add(new Product { Id = 1, Name = "Book", Price = 50, Stock = 5 });
                Products.Add(new Product { Id = 2, Name = "Pencil", Price = 55, Stock = 4 });
                Products.Add(new Product { Id = 3, Name = "Notepad", Price = 40, Stock = 56 });
                Products.Add(new Product { Id = 4, Name = "Apple", Price = 500, Stock = 3 });
            };
        }
        public List<Product> GetAll()
        {
            return Products;
        }


        public Product Add(Product product)
        {
            Products.Add(product);
            return product;

        }

        public void Update(Product product)
        {
            var productToUpdateIndex = Products.FindIndex(p => p.Id == product.Id);
            Products[productToUpdateIndex].Name = product.Name;
            Products[productToUpdateIndex].Price = product.Price;
        }
        public void Delete(int id)
        {
            //p lere bak
            var productToDeleteIndex = Products.FindIndex(p => p.Id == id);
            Products.RemoveAt(productToDeleteIndex);
        }



    }
}
