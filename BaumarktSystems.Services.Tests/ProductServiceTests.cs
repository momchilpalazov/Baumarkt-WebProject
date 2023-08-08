using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data;
using BaumarktSystem.Services.Data.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Assert = NUnit.Framework.Assert;

namespace BaumarktSystems.Services.Tests
{
    [TestClass]
    public class ProductServiceTests
    {
       private Mock<IProductInterface> _mockProductRepository;
        private ProductService _productService;


        



        [TestInitialize]
        public void Setup()
        {

            _mockProductRepository = new Mock<IProductInterface>();
            _productService = new ProductService((Baumarkt_E_commerce_Platform.Data.BaumarktSystemDbContext)_mockProductRepository.Object);



        }



       [TestMethod]
        public async Task GetProductById_ShouldReturnProduct()
        {
            // Arrange
            var mockProductRepository = new Mock<IProductInterface>();
            var productService = new ProductService((Baumarkt_E_commerce_Platform.Data.BaumarktSystemDbContext)mockProductRepository.Object);

            var expectedProduct = new BaumarktSystem.Web.ViewModels.Home.ProductIndexViewModel { Id = 1, Name = "Test Product" };
            mockProductRepository.Setup(repo => repo.GetProductByIdAsync(1)).ReturnsAsync(expectedProduct);

            // Act
            var result = await productService.GetProductByIdAsync(1);

            // Assert
            Assert.AreEqual(expectedProduct.Id, result.Id);
            Assert.AreEqual(expectedProduct.Name, result.Name);
        }


        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}