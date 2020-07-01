using TestProject.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProject.Contracts.Entities;
using TestProject.Contracts.Repository;
using System.Linq;

namespace TestProject.Infrastructure.Repository
{
    class CatalogItemsRepository:ICatalogItemsRepository
    {
        private readonly TestDbContext _context;
        public CatalogItemsRepository(TestDbContext context)
        {
            _context = context;
        }


        public Task<List<CatalogItems>> GetCatalogItemsAsync()
        {
            return _context.CatalogItems.ToListAsync();
        }


        public Task<int> CreateAsync(CatalogItems catalogItems)
        {
            _context.CatalogItems.Add(catalogItems);
            return _context.SaveChangesAsync();
        }


        public Task<int> EditAsync(CatalogItems catalogItems)
        {
            _context.CatalogItems.Update(catalogItems);
            return _context.SaveChangesAsync();
        }


        public Task<CatalogItems> DetailsAsync(int CatalogId, int ProductId)
        {
            return _context.CatalogItems.FindAsync(CatalogId, ProductId);
        }


        public Task<int> DeleteAsync(CatalogItems catalogItems)
        {
            _context.CatalogItems.Remove(catalogItems);
            return _context.SaveChangesAsync();
        }


        public Task<bool> CatalogItemsExists(int CatalogId, int ProductId)
        {
            return _context.CatalogItems.AnyAsync(e => e.CatalogId == CatalogId && e.ProductId == ProductId);
        }


        public Task<CatalogItems> FindAsync(int CatalogId, int ProductId)
        {
            return _context.CatalogItems.FindAsync(CatalogId, ProductId);
        }
    }
}
