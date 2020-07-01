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
    public class CatalogRepository: ICatalogRepository
    {
        private readonly TestDbContext _context;
        public CatalogRepository(TestDbContext context)
        {
            _context = context;
        }


       public Task<List<Catalog>> GetCatalogsAsync()
        {
            return _context.Catalog.ToListAsync();
        }


        public Task<int> CreateAsync(Catalog catalog)
        {
            _context.Catalog.Add(catalog);
            return _context.SaveChangesAsync();
        }


        public Task<int> EditAsync(Catalog catalog)
        {
            _context.Catalog.Update(catalog);
            return _context.SaveChangesAsync();
        }


        public Task<Catalog> DetailsAsync(int id)
        {
            return _context.Catalog.FindAsync(id);
        }


        public Task<int> DeleteAsync(Catalog catalog)
        {
            _context.Catalog.Remove(catalog);
            return _context.SaveChangesAsync();
        }


        public Task<bool> CatalogExists(int id)
        {
            return _context.Catalog.AnyAsync(e => e.Id == id);
        }


        public Task<Catalog> FindAsync(int id)
        {
            return _context.Catalog.FindAsync(id);
        }
    }
}
