using ProductApi.Models;
using ProductApi.Models.Products;

namespace ProductApi.Extensions
{
    public static class CalculateExt
    {   
        // This is an extension method.It is used for calculate total price of product.
        public static int CalculateTotalPrice (this Product product)
        {
            int totalPrice= product.Price * product.Stock;
            return totalPrice;
        }

    }


}
