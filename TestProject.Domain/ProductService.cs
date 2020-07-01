using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestProject.Contracts.Entities;
using TestProject.Contracts.Repository;
using TestProject.Contracts.Services;




namespace TestProject.Domain
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger _logger;


        public ProductService(IProductRepository productRepository, ILoggerFactory loggerFactory)
        {
            _productRepository = productRepository;
            _logger = loggerFactory.CreateLogger<ProductService>();
        }


        public async Task<List<Product>> GetProductsAsync()
        {
            var result = new List<Product>();
            result = await _productRepository.GetProductsAsync();
            return result;
        }


        public async Task<int> CreateAsync(Product product)
        {
            var result = 0;
            result = await _productRepository.CreateAsync(product);
            return result;

        }


        public async Task<Product> FindAsync(int id)
        {
            var result = new Product();
            result = await _productRepository.FindAsync(id);
            return result;

        }


        public async Task<int> EditAsync(Product product)
        {
            var result = 0;
            if (!await _productRepository.ProductExists(product.Id))
            {
                return result;
            }
            try
            {
                result = await _productRepository.EditAsync(product);
            }
            catch (Exception ex)
            {             
                _logger.LogError(ex.Message);
            }
            return result;
        }


        public async Task<Product> DetailsAsync(int id)
        {
            var result = new Product();
            result = await _productRepository.DetailsAsync(id);
            return result;
        }


        public async Task<int> DeleteAsync(Product product)
        {
            var result = 0;
            if (!await _productRepository.ProductExists(product.Id))
            {
                return result;
            }
            try
            {
                result = await _productRepository.DeleteAsync(product);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return result;
        }


        public async Task<bool> ProductExists(int id)
        {
            var result = false;
            if (await _productRepository.ProductExists(id))
            {
                result = true;
            }
            return result;
        }
    }
}

