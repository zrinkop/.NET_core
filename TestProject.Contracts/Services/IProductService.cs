using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProject.Contracts.Entities;

namespace TestProject.Contracts.Services
{
    public interface IProductService
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
