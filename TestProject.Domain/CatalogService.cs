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
   public  class CatalogService : ICatalogService
    {
        private readonly ICatalogRepository _catalogRepository;
        private readonly ILogger _logger;


        public CatalogService(ICatalogRepository catalogRepository, ILoggerFactory loggerFactory)
        {
            _catalogRepository = catalogRepository;
            _logger = loggerFactory.CreateLogger<CatalogService>();
        }


        public async Task<List<Catalog>> GetCatalogsAsync()
        {
            var result = new List<Catalog>();
            result = await _catalogRepository.GetCatalogsAsync();
            return result;
        }


        public async Task<int> CreateAsync(Catalog catalog)
        {
            var result=0;
            result = await _catalogRepository.CreateAsync(catalog);
            return result;

        }


        public async Task<Catalog> FindAsync(int id)
        {
            var result = new Catalog();
            result = await _catalogRepository.FindAsync(id);
            return result;

        }


        public async Task<int> EditAsync(Catalog catalog)
        {
            var result = 0;
            if (!await _catalogRepository.CatalogExists(catalog.Id))
            {
                return result;
            }
            try
            {
                result= await _catalogRepository.EditAsync(catalog);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return result;
        }

        
        public async Task<Catalog> DetailsAsync(int id)
        {
            var result = new Catalog();
            result = await _catalogRepository.DetailsAsync(id);
            return result;
        }


        public async Task<int> DeleteAsync(Catalog catalog)
        {
            var result = 0;
            if (!await _catalogRepository.CatalogExists(catalog.Id))
            {
                return result;
            }
            try
            {
                result = await _catalogRepository.DeleteAsync(catalog);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return result;
        }


        public async Task<bool> CatalogExists(int id)
        {
            var result = false;
            if (await _catalogRepository.CatalogExists(id))
            {
                result = true;
            }
            return result;
        }
    }
}
