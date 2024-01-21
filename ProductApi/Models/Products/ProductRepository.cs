using ProductApi.Extensions;

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

        public int GetTotalValue(int id)
        {   //with GetById we can get the price of the product. Upside Calculate for like helper method not extencion method.
            int totalPrice = CalculateExt.CalculateTotalPrice(Products.Find(p => p.Id == id));
            return totalPrice;
        }


        public Product GetById(int id) 
        {   
            
            return Products.FirstOrDefault(p => p.Id == id);
        }
                                                     
        public void Update(Product product)
        {
            var productToUpdateIndex = Products.FindIndex(p => p.Id == product.Id);
            //CaculatreTotalPrice is an extension method and you have to use upline yo cant use 34.line.
            product.CalculateTotalPrice();
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
