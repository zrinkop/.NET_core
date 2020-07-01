using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.Contracts.Entities;
using TestProject.Contracts.Services;

namespace TestProject.Client.Views
{
    public class CatalogsController : Controller
    {
        private readonly ICatalogService _catalogService;


        public CatalogsController(ICatalogService catalogService)
        {
            _catalogService = catalogService;
        }

        // GET: Catalogs
        public async Task<IActionResult> Index()
        {
            return View(await _catalogService.GetCatalogsAsync());
        }

        // GET: Catalogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var catalog = await _catalogService.FindAsync(id.Value);
            if (catalog == null)
            {
                return NotFound();
            }
            return View(catalog);
        }

        // GET: Catalogs/Create
        public IActionResult Create()
        {
            var catalog = new Catalog();
            return View(catalog);
        }

        // POST: Catalogs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Catalog catalog)
        {
            if (ModelState.IsValid)
            {
                if (await _catalogService.CreateAsync(catalog) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(catalog);
        }

        // GET: Catalogs/Edit
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var catalog = await _catalogService.FindAsync(id.Value);
            if (catalog == null)
                return NotFound();
            return View(catalog);
        }

        // POST: Catalogs/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Catalog catalog)
        {
            if (id != catalog.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                if (await _catalogService.EditAsync(catalog) > 0)
                    return RedirectToAction(nameof(Index));
            }
            return View(catalog);
        }

        // GET: Catalogs/Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var catalog = await _catalogService.FindAsync(id.Value);
            if (catalog == null)
                return NotFound();
            return View(catalog);
        }

        // POST: Catalogs/Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var catalog = await _catalogService.FindAsync(id.Value);
            await _catalogService.DeleteAsync(catalog);         
            return RedirectToAction(nameof(Index));
        }
    }
}
