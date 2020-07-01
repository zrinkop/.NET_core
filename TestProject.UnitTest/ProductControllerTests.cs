using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestProject.Client.Controllers;
using TestProject.Contracts.Entities;
using TestProject.Contracts.Services;
using Xunit;

namespace TestProject.UnitTest
{
    public class ProductControllerTests
    {
        private List<Product> GetTestProducts()
        {
            var items = new List<Product>
            {
                new Product { Id=10, ProductName="xUnit Test 1" },
                new Product { Id=20, ProductName="xUnit Test 2" },
                new Product { Id=30, ProductName="xUnit Test 3" },
            };

            return items;
        }

        private Product GetTestProduct()
        {
            return new Product { Id = 100, ProductName = "xUnit Test Product" };
        }


        Mock<IProductService> serviceMoq;

        public ProductControllerTests()
        {
            serviceMoq = new Mock<IProductService>();
        }

        [Fact]
        public async Task Index_ReturnsExpectedProducts()
        {
            // Arrange
            serviceMoq.Setup(x => x.GetProductsAsync()).ReturnsAsync(GetTestProducts);
            ProductsController controller = new ProductsController(serviceMoq.Object);
            var moqProductsCount = GetTestProducts().Count;


            // Act
            var result = await controller.Index();
            var viewResult = result as ViewResult;
            var model = viewResult.Model as List<Product>;

            // Assert
            Assert.NotNull(viewResult);
            Assert.NotNull(model);
            Assert.Equal(model.Count, moqProductsCount);
        }

        [Fact]
        public async Task Details_ReturnsExpectedProduct()
        {
            // Arrange
            serviceMoq.Setup(x => x.FindAsync(100)).ReturnsAsync(GetTestProduct);
            ProductsController controller = new ProductsController(serviceMoq.Object);

            // Act
            var result = await controller.Details(100);
            var viewResult = result as ViewResult;
            var model = viewResult.Model as Product;

            // Assert
            Assert.NotNull(viewResult);
            Assert.NotNull(model);
            Assert.Equal(100, model.Id);
        }


    }
}
