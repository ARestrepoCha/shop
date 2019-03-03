
namespace Shop.Web.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Shop.Web.Data.Entities;

    public interface IRepository
    {
        void AddProduct(Product product);

        void DeleteProduct(Product product);

        Product GetProduct(int id);

        IEnumerable<Product> GetProducts();

        bool ProductExits(int id);

        Task<bool> SaveAllSync();

        void UpdateProduct(Product product);
    }
}