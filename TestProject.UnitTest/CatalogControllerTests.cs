using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Threading.Tasks;
using TestProject.Client.Views;
using TestProject.Contracts.Entities;
using TestProject.Contracts.Services;
using Xunit;

namespace TestProject.UnitTest
{
    public class CatalogControllerTests
    {
        Mock<ICatalogService> serviceMoq;


        private List<Catalog> GetTestCatalogs()
        {
            var items = new List<Catalog>
            {
                new Catalog { Id=10, CatalogName="xUnit Catalog 1" },
                new Catalog { Id=20, CatalogName="xUnit Catalog 2" },
                new Catalog { Id=30, CatalogName="xUnit Catalog 3" },
            };

            return items;
        }


        private Catalog GetCatalog()
        {
            return new Catalog { Id = 100, CatalogName = "xUnit New Catalog" };
        }


        public CatalogControllerTests()
        {
            serviceMoq = new Mock<ICatalogService>();
        }

        [Fact]
        public async Task Index_ReturnsExpectedCatalogs()
        {
            // Arrange
            serviceMoq.Setup(x => x.GetCatalogsAsync()).ReturnsAsync(GetTestCatalogs);
            CatalogsController controller = new CatalogsController(serviceMoq.Object);
            var moqCatalogsCount = GetTestCatalogs().Count;

            // Act
            var result = await controller.Index();
            var viewResult = result as ViewResult;
            var model = viewResult.Model as List<Catalog>;

            // Assert
            Assert.NotNull(viewResult);
            Assert.NotNull(model);
            Assert.Equal(model.Count, moqCatalogsCount);
        }

        [Fact]
        public async Task Details_ReturnsExpectedCatalog()
        {
            // Arrange
            serviceMoq.Setup(x => x.FindAsync(100)).ReturnsAsync(GetCatalog);
            CatalogsController controller = new CatalogsController(serviceMoq.Object);

            // Act
            var result = await controller.Details(100);
            var viewResult = result as ViewResult;
            var model = viewResult.Model as Catalog;

            // Assert
            Assert.NotNull(viewResult);
            Assert.NotNull(model);
            Assert.Equal(100, model.Id);
        }

    }
}


