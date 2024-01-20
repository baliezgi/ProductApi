using ProductApi.Models.DTOs;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;

namespace ProductApi.Models.Products
{ 
    public class ProductService(IProductRepository productRepository) : IProductService
    {
        private readonly IProductRepository _productRepository = productRepository;

        public List<ProductDto> GetAll()
        {
            var products = productRepository.GetAll();

            return products.Select(product=> new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Stock=product.Stock

            }).ToList();

        }
        public Product AddProduct(ProductAddDtoRequest request)
        {
            int id = new Random().Next(1, 1000);

            var products = new Product
            {
                Id = id,
                Name = request.Name,
                Price = request.Price
                
            };
            productRepository.Add(products);

            return products;
        }

        public void DeleteProduct(int id)
        {
            productRepository.Delete(id);
        }
         
        public int GetTotalValue(int id)
        {
            return productRepository.GetTotalValue(id);
        }


        public ProductDto GetById(int id)
        {
            var product = productRepository.GetById(id);

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }
        

        public void Update(ProductUpdateDtoRequest request)
        {
            Product product = new Product
            {
                Id = request.Id,
                Name = request.Name,
                Price = request.Price

            };
            productRepository.Update(product);

        }
    }
}
