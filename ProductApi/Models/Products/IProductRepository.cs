namespace ProductApi.Models.Products
{
    public interface IProductRepository
    {
        List<Product> GetAll();

        Product Add(Product product);

        Product Update(Product product);

        List<Product> Delete(int id);

        Product GetById(int id);

        int GetTotalValue(int id);

    }
}
