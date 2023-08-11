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
    public class ApplicationTypeServiceTests
    {


        private Mock<IApplicationTypeInterface> _mockApplicationTypeRepository;
        private ApplicationTypeService _applicationTypeService;


        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<BaumarktSystemDbContext>()
               .UseInMemoryDatabase(databaseName: "TestDatabase2")
               .Options;

            var dbContext = new BaumarktSystemDbContext(options);

            _mockApplicationTypeRepository = new Mock<IApplicationTypeInterface>();
            _applicationTypeService = new ApplicationTypeService(dbContext);
        }

        [Test]

        public async Task GetAllApplicationTypesAsync_ShouldReturnAllApplicationTypes()
        {
            // Arrange
            var expectedApplicationTypes = new List<ApplicationTypeIndexViewModel>
            {
                new ApplicationTypeIndexViewModel { Id = 1, Name = "ApplicationType 1" },
                new ApplicationTypeIndexViewModel { Id = 2, Name = "ApplicationType 2" },
                new ApplicationTypeIndexViewModel { Id = 3, Name = "ApplicationType 3" },
            };

            _mockApplicationTypeRepository.Setup(repo => repo.GetAllApplicationTypesAsync()).
                Returns(Task.FromResult<IEnumerable<ApplicationTypeIndexViewModel>>(expectedApplicationTypes));

            // Act
            IEnumerable<ApplicationTypeIndexViewModel> result = await _applicationTypeService.GetAllApplicationTypesAsync();

            // Assert

            Assert.That(result.First().Id, Is.EqualTo(expectedApplicationTypes.First().Id));
            Assert.That(result.First().Name, Is.EqualTo(expectedApplicationTypes.First().Name));


        }


        [Test]

        public async Task GetApplicationTypeByIdAsync_ShouldReturnApplicationTypeById()
        {
            // Arrange
            var expectedApplicationType = new ApplicationTypeIndexViewModel { Id = 1, Name = "ApplicationType 1" };

            _mockApplicationTypeRepository.Setup(repo => repo.GetApplicationTypeByIdAsync(1)).
                Returns(Task.FromResult<ApplicationTypeIndexViewModel>(expectedApplicationType));

            // Act
            ApplicationTypeIndexViewModel result = await _applicationTypeService.GetApplicationTypeByIdAsync(1);

            // Assert

            Assert.That(result.Id, Is.EqualTo(expectedApplicationType.Id));
            Assert.That(result.Name, Is.EqualTo(expectedApplicationType.Name));
        }

        [Test]

        public async Task CreateApplicationTypeAsync_ShouldCreateApplicationType()
        {
            // Arrange
            var expectedApplicationType = new ApplicationTypeIndexViewModel { Id = 1, Name = "ApplicationType 1" };

            _mockApplicationTypeRepository.Setup(repo => repo.CreateApplicationTypeAsync(expectedApplicationType)).
              Returns(Task.CompletedTask);


            
        }


        [Test]

        public async Task EditApplicationTypePostAsync_ShouldUpdateApplicationType()
        {
            // Arrange
            var expectedApplicationType = new ApplicationTypeIndexViewModel { Id = 1, Name = "ApplicationType 1" };

            _mockApplicationTypeRepository.Setup(repo => repo.EditApplicationTypePostAsync(expectedApplicationType)).
              Returns(Task.CompletedTask);

            // Act
            await _applicationTypeService.EditApplicationTypePostAsync(expectedApplicationType);

            // Assert

            _mockApplicationTypeRepository.Verify(repo => repo.EditApplicationTypePostAsync(expectedApplicationType), Times.Once);
        }

        [Test]

        public async Task DeleteApplicationTypeAsync_ShouldDeleteApplicationType()
        {
            // Arrange
            var expectedApplicationType = new ApplicationTypeIndexViewModel { Id = 1, Name = "ApplicationType 1" };

            _mockApplicationTypeRepository.Setup(repo => repo.DeleteApplicationTypeAsync(expectedApplicationType)).
              Returns(Task.CompletedTask);

            // Act
            await _applicationTypeService.DeleteApplicationTypeAsync(expectedApplicationType);

            // Assert

            _mockApplicationTypeRepository.Verify(repo => repo.DeleteApplicationTypeAsync(expectedApplicationType), Times.Once);
        }





    }
}
