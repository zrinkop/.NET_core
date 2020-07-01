using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProject.Contracts.Entities;
using TestProject.Contracts.Repository;
using TestProject.Contracts.Services;


namespace TestProject.Domain
{
    class CatalogItemsService:ICatalogItemsService
    {
        private readonly ICatalogItemsRepository _catalogItemsRepository;
        private readonly ILogger _logger;


        public CatalogItemsService(ICatalogItemsRepository catalogItemsRepository, ILoggerFactory loggerFactory)
        {
            _catalogItemsRepository = catalogItemsRepository;
            _logger = loggerFactory.CreateLogger<CatalogItemsService>();
        }


        public async Task<List<CatalogItems>> GetCatalogItemsAsync()
        {
            var result = new List<CatalogItems>();
            result = await _catalogItemsRepository.GetCatalogItemsAsync();
            return result;
        }


        public async Task<int> CreateAsync(CatalogItems catalogItems)
        {
            var result = 0;
            result = await _catalogItemsRepository.CreateAsync(catalogItems);
            return result;

        }


        public async Task<CatalogItems> FindAsync(int CatalogId, int ProductId)
        {
            var result = new CatalogItems();
            result = await _catalogItemsRepository.FindAsync(CatalogId, ProductId);
            return result;

        }


        public async Task<int> EditAsync(CatalogItems catalogItems)
        {
            var result = 0;
            if (!await _catalogItemsRepository.CatalogItemsExists(catalogItems.CatalogId, catalogItems.ProductId))
            {
                return result;
            }
            try
            {
                result = await _catalogItemsRepository.EditAsync(catalogItems);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return result;
        }

       
        public async Task<CatalogItems> DetailsAsync(int CatalogId, int ProductId)
        {
            var result = new CatalogItems();
            result = await _catalogItemsRepository.DetailsAsync(CatalogId, ProductId);
            return result;
        }


        public async Task<int> DeleteAsync(CatalogItems catalogItems)
        {
            var result = 0;
            if (!await _catalogItemsRepository.CatalogItemsExists(catalogItems.CatalogId, catalogItems.ProductId))
            {
                return result;
            }
            try
            {
                result = await _catalogItemsRepository.DeleteAsync(catalogItems);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return result;
        }


        public async Task<bool> CatalogItemsExists(int CatalogId, int ProductId)
        {
            var result = false;
            if (await _catalogItemsRepository.CatalogItemsExists(CatalogId, ProductId))
            {
                result = true;
            }
            return result;
        }
    }
}
