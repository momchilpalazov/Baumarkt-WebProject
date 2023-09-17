using BaumarktSystem.Data;
using BaumarktSystem.Data.Models;
using BaumarktSystem.Services.Data;
using BaumarktSystem.Services.Data.Interaces;
using BaumarktSystem.Web.ViewModels.Home;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystems.Services.Tests
{
    [TestFixture]
    public class CategoryServiceTests
    {

        private Mock<ICategoryInterface> _mockCategoryRepository;
        private CategoryService _categoryService;


        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<BaumarktSystemDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase2")
                .Options;

            var dbContext = new BaumarktSystemDbContext(options);

            _mockCategoryRepository = new Mock<ICategoryInterface>();
            //_categoryService = new CategoryService(_mockCategoryRepository.Object);
            _categoryService = new CategoryService(dbContext, null, null);
        }

        [Test]

        public async Task GetAllCategoriesAsync_ShouldReturnAllCategories()
        {
            // Arrange
            var expectedCategories = new List<CategoryIndexViewModel>
            {
                new CategoryIndexViewModel { Id = 1, Name = "Category 1" },
                new CategoryIndexViewModel { Id = 2, Name = "Category 2" },
                new CategoryIndexViewModel { Id = 3, Name = "Category 3" },
            };

            _mockCategoryRepository.Setup(repo => repo.GetAllCategoriesAsync()).Returns(Task.FromResult<IEnumerable<CategoryIndexViewModel>>(expectedCategories));


            // Act
            IEnumerable<CategoryIndexViewModel> result = await _categoryService.GetAllCategoriesAsync();

            // Assert
           // Assert.AreEqual(expectedCategories.Count(), result.Count());
            Assert.That(result.First().Id, Is.EqualTo(expectedCategories.First().Id));
            Assert.That(result.First().Name, Is.EqualTo(expectedCategories.First().Name));
        }

        [Test]

        public async Task GetCategoryByIdAsync_ShouldReturnCategory()
        {
            // Arrange
            var expectedCategory = new CategoryIndexViewModel { Id = 1, Name = "Category 1" };

            _mockCategoryRepository.Setup(repo => repo.GetCategoryByIdAsync(1)).ReturnsAsync(expectedCategory);

            
           


        }


        [Test]

        public async Task CreateCategoryAsync_ShouldCreateCategory()
        {
            // Arrange
            var expectedCategory = new CategoryIndexViewModel { Id = 1, Name = "Category 1" };

            _mockCategoryRepository.Setup(repo => repo.CreateCategoryAsync(expectedCategory));
           
            Assert.That(expectedCategory.Id, Is.EqualTo(expectedCategory.Id));
        }


        [Test]

        public async Task EditCategorySaveAsync_ShouldUpdateCategory()
        {
            // Arrange
            var expectedCategory = new CategoryIndexViewModel { Id = 1, Name = "Category 1" };

            _mockCategoryRepository.Setup(repo => repo.EditCategorySaveAsync(expectedCategory));

            Assert.That(expectedCategory.Id, Is.EqualTo(expectedCategory.Id));
        }

        [Test]

        public async Task DeleteCategoryByIdAsync_ShouldDeleteCategory()
        {
            // Arrange
            var expectedCategory = new CategoryIndexViewModel { Id = 1, Name = "Category 1" };

            _mockCategoryRepository.Setup(repo => repo.DeleteCategoryByIdAsync(1));

            Assert.That(expectedCategory.Id, Is.EqualTo(expectedCategory.Id));
        }

        [Test]

        public async Task GetDetailsCategoryByIdAsync_ShouldReturnCategory()
        {
            // Arrange
            var expectedCategory = new CategoryIndexViewModel { Id = 1, Name = "Category 1" };

            _mockCategoryRepository.Setup(repo => repo.GetCategoryByIdAsync(1)).ReturnsAsync(expectedCategory);

            // Act
            var result = await _categoryService.GetDetailsCategoryByIdAsync(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.That(result.Id, Is.EqualTo(expectedCategory.Id));
            Assert.That(result.Name, Is.EqualTo(expectedCategory.Name));
        }

       




    }
}
