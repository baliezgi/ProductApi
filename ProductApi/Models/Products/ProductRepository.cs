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
                Products.Add(new Product { Id = 1, Name = "Book", Price = 50, Stock = 5, Description= "aaaaaaaaaaaaaaaa", Size= "XL" });
                Products.Add(new Product { Id = 2, Name = "Pencil", Price = 55, Stock = 4, Description = "bbbbbbbbbbbbbbb", Size = "XXL" });
                Products.Add(new Product { Id = 3, Name = "Notepad", Price = 40, Stock = 56, Description = "ccccccccccccc", Size = "XL" });
                Products.Add(new Product { Id = 4, Name = "Apple", Price = 500, Stock = 3, Description = "dddddddddddddd", Size = "XXL" });
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

        public Product Update(Product product)
        {
            var productToUpdateIndex = Products.FindIndex(p => p.Id == product.Id);


            Products[productToUpdateIndex].Name = product.Name;
            Products[productToUpdateIndex].Price = product.Price;


            //CaculatreTotalPrice is an extension method.
            Console.WriteLine(product.CalculateTotalPriceEx());
            return product;


        }

        public int GetTotalValue(int id)
        {   //with GetById we can get the price of the product.
            //Upside Calculate for like helper method not extencion method.
           // int totalPrice = CalculateExt.CalculateTotalPrice(Products.Find(p => p.Id == id));
            int totalPrice = ProductHelper.CalculateTotalPriceHelper(Products.Find(p => p.Id == id));
            return totalPrice;
        }


        public Product? GetById(int id) 
        {   
            
            return Products.FirstOrDefault(p => p.Id == id);
        }
                                                     
        
        public List<Product> Delete(int id)
        {
            //p lere bak
            var productToDeleteIndex = Products.FindIndex(p => p.Id == id);
            Products.RemoveAt(productToDeleteIndex);
            return Products;
        }



    }
}
