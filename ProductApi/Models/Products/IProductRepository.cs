﻿namespace ProductApi.Models.Products
{
    public interface IProductRepository
    {
        List<Product> GetAll();

        Product Add(Product product);

        void Update(Product product);
        void Delete(int id);

        Product GetById(int id);
        int GetTotalValue(int id);

    }
}
