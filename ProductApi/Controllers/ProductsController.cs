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
            
            return Ok(productService.GetAll());

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(productService.GetById(id));
        }

        

        [HttpPost]
        public IActionResult AddProduct(ProductAddDtoRequest request)
        {
            var result = productService.AddProduct(request);
            return Created("", result);
            //buraya bak 506 geliyor budy de
        }

        [HttpPut]
        public IActionResult Update(ProductUpdateDtoRequest request)
        {

            productService.Update(request);
            return NoContent();
        }



        [HttpGet("{id}")]
        public IActionResult Delete(int id)
        {
            productService.DeleteProduct(id);
            return NoContent();
        }

        

  

        //[Route("simple-add/{version}")]
        //[HttpPost]
        //public IActionResult SimpleAdd(ProductAddDtoRequest request, [FromRoute] string version)
        //{
        //    var result = productService.AddProduct(request);
        //    return Created("", result);
        //}

        //[HttpPost] Add Action 
        //public IActionResult Add() => Created("", 10);



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