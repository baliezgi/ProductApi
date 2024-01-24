using ProductApi.Models.DTOs;

namespace ProductApi.Models.Products
{
    public interface IProductService
    {
        List<ProductDto> GetAll();
        ResponseDto<int> AddProduct(ProductAddDtoRequest request);
        Product Update(ProductUpdateDtoRequest product);
        List<ProductDto> DeleteProduct(int id);
        ProductDto GetById(int id);
        int GetTotalValue(int id);
       

    }
}

//public interface IProductService
//{
//    IEnumerable<Product> GetAllProducts();
//    Product AddProduct(Product product);
//    void UpdateProduct(Product product);
//    void DeleteProduct(int id);
//}
