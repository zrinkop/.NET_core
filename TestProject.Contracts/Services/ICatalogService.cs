using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProject.Contracts.Entities;

namespace TestProject.Contracts.Services
{
   public interface ICatalogService
    {
        Task<List<Catalog>> GetCatalogsAsync();
        Task<int> CreateAsync(Catalog catalog);
        Task<int> EditAsync(Catalog catalog);
        Task<Catalog> DetailsAsync(int id);
        Task<int> DeleteAsync(Catalog catalog);
        Task<bool> CatalogExists(int id);
        Task<Catalog> FindAsync(int id);
    }
}
