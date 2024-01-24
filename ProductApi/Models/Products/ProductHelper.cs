namespace ProductApi.Models.Products
{
    public class ProductHelper
    {
        public static int CalculateTotalPriceHelper(Product product)
        {
            int totalPrice = product.Price * product.Stock;
            return totalPrice;
        }
    }
}
