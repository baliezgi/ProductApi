using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Filters;
using ProductApi.Mapping;
using ProductApi.Models;
using ProductApi.Models.DTOs;
using ProductApi.Models.Products;


namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            List<ProductDto> products = _productService.GetAll();
            return Ok(products);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_productService.GetById(id));
        }

        [HttpGet("{id}/totalValue")]
        public IActionResult GetTotalValue(int id)
        {
            return Ok(_productService.GetTotalValue(id));
        }

        [HttpPost]
        public IActionResult AddProduct(ProductAddDtoRequest request)
        {
            
            var product = _productService.AddProduct(request);
            return Created("", product);

        }

        [HttpPut]
        public IActionResult Update(ProductUpdateDtoRequest request)
        {
            return Ok();
        }

        //[ServiceFilter<ActionFilter>]
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    //productService.DeleteProduct(id);
        //    //return GetAll();
        //}


    }

}