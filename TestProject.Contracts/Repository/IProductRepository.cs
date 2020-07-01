using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProject.Contracts.Entities;

namespace TestProject.Contracts.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProductsAsync();
        Task<int> CreateAsync(Product product);
        Task<int> EditAsync(Product product);
        Task<Product> DetailsAsync(int id);
        Task<int> DeleteAsync(Product product);
        Task<bool> ProductExists(int id);
        Task<Product> FindAsync(int id);
    }
}
