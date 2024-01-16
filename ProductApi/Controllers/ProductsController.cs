using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using ProductApi.Models.DTOs;
using ProductApi.Models.Products;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController: ControllerBase
    {
        public readonly IProductService productService = new ProductService(new ProductRepository());

        [HttpGet]
        public IActionResult GetAll()
        {
            
            var products = productService.GetAllProducts();
            return Ok(products);

        }

        //[HttpPost]
        //public IActionResult Add() => Created("", 10);

        [HttpPost]
        public IActionResult AddProduct(ProductAddDtoRequest request)
        {
            var result = productService.AddProduct(request);
            return Created("", result);
        }


    }

}







//public Product AddProduct(Product product)
//{
//    if (product == null)
//    {
//        throw new ArgumentNullException(nameof(product));
//    }
//    return _productRepository.Add(product);

//}

//public void DeleteProduct(int id)
//{
//    _productRepository.Delete(id);
//}



//public void UpdateProduct(Product product)
//{
//    if (product == null)
//    {
//        throw new ArgumentNullException(nameof(product));
//    }
//    _productRepository.Update(product);

//}
//    }