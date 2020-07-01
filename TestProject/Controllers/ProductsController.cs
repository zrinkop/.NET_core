using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.Contracts.Entities;
using TestProject.Contracts.Services;

namespace TestProject.Client.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _productService.GetProductsAsync());
        }


        // GET: Products/Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
            var product = await _productService.FindAsync(id.Value);
            if (product == null)
                return NotFound();     
            return View(product);
        }


        // GET: Products/Create
        public IActionResult Create()
        {
            var product = new Product();
            return View(product);
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductName,ProductDescription,BasePrice,CreatedBy,CreatedDateUtc,LastModifiedBy,LastModifiedDateUtc,IsDeleted")] Product product)
        {
            if (ModelState.IsValid)
            {
                if (await _productService.CreateAsync(product) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(product);
        }


        // GET: Products/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var product = await _productService.FindAsync(id.Value);
            if (product == null)
                return NotFound();
            return View(product);
        }


        // POST: Products/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id, ProductName, ProductDescription, BasePrice, CreatedBy, CreatedDateUtc, LastModifiedBy, LastModifiedDateUtc, IsDeleted")] Product product)
        public async Task<IActionResult> Edit(int id, Product product)
        {
            if (id != product.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                if (await _productService.EditAsync(product) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(product);
        }


        // GET: Products/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var product = await _productService.FindAsync(id.Value);
            if (product == null)
                return NotFound();
            return View(product);
        }


        // POST: Products/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var product = await _productService.FindAsync(id.Value);
            await _productService.DeleteAsync(product);
            return RedirectToAction(nameof(Index));
        }
    }
}
