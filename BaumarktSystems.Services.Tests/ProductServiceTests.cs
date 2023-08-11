

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
            Assert.That(result.Id, Is.EqualTo(expectedProduct.Id));
            Assert.That(result.FullName, Is.EqualTo(expectedProduct.FullName));
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
            Assert.That(result.Count(), Is.EqualTo(expectedProducts.Count));
            Assert.That(result.ElementAt(0).Id, Is.EqualTo(expectedProducts[0].Id));
            Assert.That(result.ElementAt(0).FullName, Is.EqualTo(expectedProducts[0].FullName));
            Assert.That(result.ElementAt(1).Id, Is.EqualTo(expectedProducts[1].Id));
            Assert.That(result.ElementAt(1).FullName, Is.EqualTo(expectedProducts[1].FullName));
            Assert.That(result.ElementAt(2).Id, Is.EqualTo(expectedProducts[2].Id));
            Assert.That(result.ElementAt(2).FullName, Is.EqualTo(expectedProducts[2].FullName));
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
            Assert.That(result.Count(), Is.EqualTo(expectedProducts.Count));
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


        [Test]

        public async Task GetProductById_ShouldReturnNull()
        {
            // Arrange
            int productId = 1;
            ProductIndexViewModel expectedProduct = null;

            // Setup the mock repository behavior
            _mockProductRepository.Setup(repo => repo.GetProductByIdAsync(productId)).ReturnsAsync(expectedProduct);

            // Act
            var result = await _productService.GetProductByIdAsync(productId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]

        public async Task GetAllProducts_ShouldReturnNull()
        {
            // Arrange
            List<ProductIndexViewModel> expectedProducts = null;

            // Setup the mock repository behavior
            _mockProductRepository.Setup(repo => repo.GetAllProductsAsync()).ReturnsAsync(expectedProducts);

            // Act
            var result = await _productService.GetAllProductsAsync();

            // Assert
            Assert.IsNull(result);
        }

        
       

    }
}

