using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Filters;
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

        [HttpGet("{id}/totalValue")]
        public IActionResult GetTotalValue(int id)
        {
            return Ok(productService.GetTotalValue(id));
        }

        [HttpPost]
        public IActionResult AddProduct(ProductAddDtoRequest request)
        {
            return Ok();
            //var result = productService.AddProduct(request);
            //return Created("", result);
            
        }

        [HttpPut]
        public IActionResult Update(ProductUpdateDtoRequest request)
        {
            productService.Update(request);
            return NoContent();
        }

        [ServiceFilter<ActionFilter>]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            productService.DeleteProduct(id);
            return GetAll();
        }


    }

}