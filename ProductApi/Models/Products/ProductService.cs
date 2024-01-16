using ProductApi.Models.DTOs;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;

namespace ProductApi.Models.Products
{ 
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        private readonly IProductRepository _productRepository = productRepository;

        public int AddProduct(ProductAddDtoRequest request)
        {
            var id = new Random().Next(1, 1000);

            var products = new Product
            {
                Id = id,
                Name = request.Name,
                Price = request.Price
                
            };
            productRepository.Add(products);

            return products.Id;



        }

        public void DeleteProduct(int id)
        {
            productRepository.Delete(id);
        }
         
        public List<Product> GetAllProducts()
        {
            return productRepository.GetAll();
        }

        public void UpdateProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            productRepository.Update(product);

        }
    }
}
