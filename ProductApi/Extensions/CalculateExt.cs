using ProductApi.Models;
using ProductApi.Models.Products;

namespace ProductApi.Extensions
{
    public static class CalculateExt
    {   
        // This is an extension method.It is used for calculate total price of product.
        // At the same time we have a same helper method this project.
        // Because I didn't fix on my mind difference of between helper method and extencion method. 
        public static int CalculateTotalPriceEx (this Product product)
        {
            int totalPrice= product.Price * product.Stock;
            return totalPrice;
        }

    }


}
