using ProductApi.Models.DTOs;

namespace ProductApi.Models.Products
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        //Product GetProductById(int id);
        int AddProduct(ProductAddDtoRequest request);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);



    }
}

//public interface IProductService
//{
//    IEnumerable<Product> GetAllProducts();
//    Product AddProduct(Product product);
//    void UpdateProduct(Product product);
//    void DeleteProduct(int id);
//}
