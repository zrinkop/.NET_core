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
    public class ProductRepository : IProductRepository
    {
        private readonly TestDbContext _context;
        public ProductRepository(TestDbContext context)
        {
            _context = context;
        }


        public Task<List<Product>> GetProductsAsync()
        {
            return _context.Product.ToListAsync();
        }


        public Task<int> CreateAsync(Product product)
        {
            _context.Product.Add(product);
            return _context.SaveChangesAsync();
        }


        public Task<int> EditAsync(Product product)
        {
            _context.Product.Update(product);
            return _context.SaveChangesAsync();
        }


        public Task<Product> DetailsAsync(int id)
        {
            return _context.Product.FindAsync(id);
        }


        public Task<int> DeleteAsync(Product product)
        {
            _context.Product.Remove(product);
            return _context.SaveChangesAsync();
        }


        public Task<bool> ProductExists(int id)
        {
            return _context.Product.AnyAsync(e => e.Id == id);
        }


        public Task<Product> FindAsync(int id)
        {
            return _context.Product.FindAsync(id);
        }
    }
}

