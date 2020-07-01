using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestProject.Contracts.Entities;
using TestProject.Infrastructure;

namespace TestProject.Client.Views.Products
{
    public class IndexModel : PageModel
    {
        private readonly TestProject.Infrastructure.TestDbContext _context;

        public IndexModel(TestProject.Infrastructure.TestDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
