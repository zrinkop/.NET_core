
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.Contracts.Entities;
using TestProject.Contracts.Services;

namespace TestProject.Client.Controllers
{
    public class CatalogItemsController : Controller
    {
        private readonly ICatalogItemsService _catalogItemsService;
        private readonly IProductService _productService;
        private readonly ICatalogService _catalogService;


        public CatalogItemsController(ICatalogItemsService catalogItemsService, IProductService productService, ICatalogService catalogService)
        {
            _catalogItemsService = catalogItemsService;
            _productService = productService;
            _catalogService = catalogService;
        }


        // GET: CatalogItems
        public async Task<IActionResult> Index(int id)
        {
            Catalog catalog = await _catalogService.DetailsAsync(id);
            var products = await _productService.GetProductsAsync();
            var catalogItems = await _catalogItemsService.GetCatalogItemsAsync();
            var checkedItems = new List<int>();           
            foreach (CatalogItems item in catalogItems)
            {
                if(item.CatalogId == id)
                    checkedItems.Add(item.ProductId);
            }
            var filteredProducts = products.Where(e => checkedItems.Contains(e.Id));
            ViewBag.CatalogId = id;
            ViewBag.Selected = filteredProducts;
            ViewBag.CatalogName = catalog.CatalogName;
            return View(products);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int catalogId, List<int> items)
        {
            var products = await _productService.GetProductsAsync();
            foreach (Product item in products)
            {
                var catalogItems = new CatalogItems() { CatalogId = catalogId, ProductId = item.Id };
                await _catalogItemsService.DeleteAsync(catalogItems);
            }
            foreach (int item in items)
            {
                var catalogItems = new CatalogItems() { CatalogId = catalogId, ProductId = item };
                await _catalogItemsService.CreateAsync(catalogItems);
            }
            return RedirectToAction("Index", "Catalogs"); ;
        }


        // GET: Catalogs/Details
        public async Task<IActionResult> Details(int? catalogId, int? productId)
        {
            if (catalogId == null || productId == null)
                return NotFound();
            var catalogItems = await _catalogItemsService.FindAsync(catalogId.Value, productId.Value);
            if (catalogItems == null)
                return NotFound();
            return View(catalogItems);
        }


        // GET: Catalogs/Create
        public IActionResult Create()
        {
            return View();
        }


        // POST: Catalogs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,CatalogId")] CatalogItems catalogItems)
        {
            if (ModelState.IsValid)
            {
                if (await _catalogItemsService.CreateAsync(catalogItems) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(catalogItems);
        }
    }
}
