//using BaumarktSystem.Data;
//using BaumarktSystem.Data.Models;
//using BaumarktSystem.Services.Data;
//using BaumarktSystem.Services.Data.Interfaces;
//using BaumarktSystem.Web.ViewModels.Home;
//using Microsoft.EntityFrameworkCore;
//using Moq;
//using NUnit.Framework;
//using System.Threading.Tasks;
//using System.Collections.Generic;

//namespace BaumarktSystems.Services.Tests
//{
//    [TestFixture]
//    public class ProductServiceTests
//    {
//        private Mock<IProductInterface> _mockProductRepository;
//        private ProductService _productService;

//        private DbContextOptions<BaumarktSystemDbContext> _options;







//        [SetUp]
//        public void Setup()
//        {
//            var options = new DbContextOptionsBuilder<BaumarktSystemDbContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;

//            var dbContext = new BaumarktSystemDbContext(options);

//            _mockProductRepository = new Mock<IProductInterface>();
//            _productService = new ProductService(dbContext);
//        }

//        [Test]
//        public async Task GetProductById_ShouldReturnProduct()
//        {
//            // Arrange
//            var expectedProduct = new ProductIndexViewModel { Id = 1, FullName = "Test Product" };

//            // Използвайте ин-мемори база данни
//            var options = new DbContextOptionsBuilder<BaumarktSystemDbContext>()
//                .UseInMemoryDatabase(databaseName: "TestDatabase")
//                .Options;

//            // Използвайте контекст с ин-мемори база данни
//            using (var dbContext = new BaumarktSystemDbContext(options))
//            {
//                // Инициализирайте репозиториите, ако са нужни
//                // Не създавайте ProductService тук, тъй като той вече се инициализира със създаването на dbContext

//                // Arrange the mock repository behavior
//                _mockProductRepository.Setup(repo => repo.GetProductByIdAsync(1)).ReturnsAsync(expectedProduct);

//                // Act
//                var result = await _productService.GetProductByIdAsync(1);

//                // Assert
//                Assert.AreEqual(expectedProduct.Id, result.Id);
//                Assert.AreEqual(expectedProduct.FullName, result.FullName);
//            }
//        }


//    }
//}

using NUnit.Framework;
using Moq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BaumarktSystem.Services.Data.Interfaces;
using BaumarktSystem.Web.ViewModels.Home;
using BaumarktSystem.Data;
using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data;

namespace BaumarktSystems.Services.Tests
{
    [TestFixture]
    public class ProductServiceTests
    {
        private Mock<IProductInterface> _mockProductRepository;
        private ProductService _productService;

        [SetUp]
        public void Setup()
        {

            var options = new DbContextOptionsBuilder<BaumarktSystemDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            var dbContext = new BaumarktSystemDbContext(options);

            _mockProductRepository = new Mock<IProductInterface>();
            _productService = new ProductService(dbContext);

            
        }

        [Test]
        public async Task GetProductById_ShouldReturnProduct()
        {
            // Arrange
            int productId = 1;
            var expectedProduct = new ProductIndexViewModel { Id = productId, FullName = "Test Product" };

            // Setup the mock repository behavior
            _mockProductRepository.Setup(repo => repo.GetProductByIdAsync(productId)).ReturnsAsync(expectedProduct);

            // Act
            var result = await _productService.GetProductByIdAsync(productId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedProduct.Id, result.Id);
            Assert.AreEqual(expectedProduct.FullName, result.FullName);
        }



        [Test]
        public async Task GetAllProducts_ShouldReturnAllProducts()
        {
            // Arrange
            var expectedProducts = new List<ProductIndexViewModel>
            {
                new ProductIndexViewModel { Id = 1, FullName = "Test Product 1" },
                new ProductIndexViewModel { Id = 2, FullName = "Test Product 2" },
                new ProductIndexViewModel { Id = 3, FullName = "Test Product 3" },
            };

            // Setup the mock repository behavior
            _mockProductRepository.Setup(repo => repo.GetAllProductsAsync()).ReturnsAsync(expectedProducts);

            // Act
            var result = await _productService.GetAllProductsAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedProducts.Count, result.Count());
            Assert.AreEqual(expectedProducts[0].Id, result.ElementAt(0).Id);
            Assert.AreEqual(expectedProducts[0].FullName, result.ElementAt(0).FullName);
            Assert.AreEqual(expectedProducts[1].Id, result.ElementAt(1).Id);
            Assert.AreEqual(expectedProducts[1].FullName, result.ElementAt(1).FullName);
            Assert.AreEqual(expectedProducts[2].Id, result.ElementAt(2).Id);
            Assert.AreEqual(expectedProducts[2].FullName, result.ElementAt(2).FullName);
        }

        [Test]
        public async Task GetAllProducts_ShouldReturnEmptyList()
        {
            // Arrange
            var expectedProducts = new List<ProductIndexViewModel>();

            // Setup the mock repository behavior
            _mockProductRepository.Setup(repo => repo.GetAllProductsAsync()).ReturnsAsync(expectedProducts);

            // Act
            var result = await _productService.GetAllProductsAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedProducts.Count, result.Count());
        }

        //[Test]

        //public async Task CreateProduct_ShouldCreateProduct()
        //{
        //    // Arrange
        //    var product = new ProductIndexViewModel { Id = 1, FullName = "Test Product" };

        //    // Setup the mock repository behavior
        //    _mockProductRepository.Setup(repo => repo.CreateProductAsync(product)).ReturnsAsync(product);

        //    // Act
        //    var result = await _productService.CreateProductAsync(product);

        //    // Assert
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(product.Id, result.Id);
        //    Assert.AreEqual(product.FullName, result.FullName);
        //}

        //[Test]

        //public async Task UpdateProduct_ShouldUpdateProduct()
        //{
        //    // Arrange
        //    var product = new ProductIndexViewModel { Id = 1, FullName = "Test Product" };

        //    // Setup the mock repository behavior
        //    _mockProductRepository.Setup(repo => repo.EditProductAsync(product)).ReturnsAsync(product);

        //    // Act
        //    var result = await _productService.EditProductAsync(product);

        //    // Assert
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(product.Id, result.Id);
        //    Assert.AreEqual(product.FullName, result.FullName);
        //}

        //[Test]

        //public async Task DeleteProduct_ShouldDeleteProduct()
        //{
        //    // Arrange
        //    var product = new ProductIndexViewModel { Id = 1, FullName = "Test Product" };

        //    // Setup the mock repository behavior
        //    _mockProductRepository.Setup(repo => repo.DeleteProductByIdAsync(product.Id)).ReturnsAsync(product);

        //    // Act
        //    var result = await _productService.DeleteProductByIdAsync(product.Id);

        //    // Assert
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(product.Id, result.Id);
        //    Assert.AreEqual(product.FullName, result.FullName);
        //}
    }
}

