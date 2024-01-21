using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductApi.Models.Products;

namespace ProductApi.Filters
{
    public class ActionFilter(IProductRepository productRepository): Attribute, IActionFilter
    {
        private readonly IProductRepository _productRepository = productRepository;

       

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var idAsObject = context.ActionArguments["id"];
            if (idAsObject is null) return;

            if(!int.TryParse(idAsObject.ToString(), out int id)) return;

            var hasProduct = _productRepository.GetById(id);
            if (hasProduct is null) context.Result=new NotFoundObjectResult($"Product with id {id} not found");


        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }


    }
}
