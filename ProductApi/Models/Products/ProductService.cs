using AutoMapper;
using ProductApi.Models.DTOs;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Json;

namespace ProductApi.Models.Products
{ 
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public List<ProductDto> GetAll()
        {
            List<Product> products = _productRepository.GetAll();
            List<ProductDto> productDtos = _mapper.Map<List<ProductDto>>(products);
            return productDtos;

            //var products = _productRepository.Pro

            //return products.Select(product=> new ProductDto
            //{
            //    Id = product.Id,
            //    Name = product.Name,
            //    Price = product.Price,
                

            //}).ToList();

        }
        public Product AddProduct(ProductAddDtoRequest request)
        {
            //with automapper
            var product = _mapper.Map<Product>(request);
            return product;

            #region without automapper

            //int id = new Random().Next(1, 1000);

            //var products = new Product
            //{
            //    Id = id,
            //    Name = request.Name,
            //    Price = request.Price

            //};
            //productRepository.Add(products); 
            #endregion

        }

        public List<ProductDto> DeleteProduct(int id)
        {
            _productRepository.Delete(id);
            return GetAll();
        }
         
        public int GetTotalValue(int id)
        {
            return _productRepository.GetTotalValue(id);
        }


        public ProductDto GetById(int id)
        {
            var product = _productRepository.GetById(id);

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }
        

        public Product Update(ProductUpdateDtoRequest request)
        {
            var product = _mapper.Map<Product>(request);
            return product;


            //Product product = new Product
            //{
            //    Id = request.Id,
            //    Name = request.Name,
            //    Price = request.Price

            //};
            //_productRepository.Update(product);

        }
    }
}
