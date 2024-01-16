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
                Price = product.Price

            }).ToList();

            //Linq ile yukarıda foreach döngüsünün aynısını yapabiliriz.
            //List<ProductDto> productDtos = new List<ProductDto>();

            //foreach (var product in products)
            //{
            //    productDtos.Add(new ProductDto
            //    {
            //        Id = product.Id,
            //        Name = product.Name,
            //        Price = product.Price
            //    });
            //}
            //return productDtos;

        }
        public int AddProduct(ProductAddDtoRequest request)
        {
            int id = new Random().Next(1, 1000);

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
