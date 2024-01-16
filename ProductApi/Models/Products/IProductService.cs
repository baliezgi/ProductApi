using ProductApi.Models.DTOs;

namespace ProductApi.Models.Products
{
    public interface IProductService
    {
        List<ProductDto> GetAll();
        //Product GetProductById(int id);
        int AddProduct(ProductAddDtoRequest request);
        void Update(ProductUpdateDtoRequest product);
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
