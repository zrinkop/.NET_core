using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProject.Contracts.Entities;

namespace TestProject.Contracts.Services
{
    public interface ICatalogItemsService
    {
        Task<List<CatalogItems>> GetCatalogItemsAsync();
        Task<int> CreateAsync(CatalogItems catalogItems);
        Task<int> EditAsync(CatalogItems catalogItems);
        Task<CatalogItems> DetailsAsync(int CatalogId, int ProductId);
        Task<int> DeleteAsync(CatalogItems catalogItems);
        Task<bool> CatalogItemsExists(int CatalogId, int ProductId);
        Task<CatalogItems> FindAsync(int CatalogId, int ProductId);
    }
}