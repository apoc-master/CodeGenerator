using CodeGenerator.Models;
using CodeGenerator.Repositories;
using CodeGenerator.Services;
using Moq;

namespace CodeGenerator.Test
{
    public class EntityServiceTests
    {
        [Fact]
        public void GetEntity_ShouldReturnEntityFromRepository()
        {
            // Arrange
            var mockRepository = new Mock<IPropertyRepository>();
            var expectedEntity = new Entity
            {
                Name = "TestEntity",
                Properties = []
            };
            mockRepository.Setup(repo => repo.GetEntity()).Returns(expectedEntity);

            var service = new EntityService(mockRepository.Object);

            // Act
            var entity = service.GetEntity();

            // Assert
            Assert.NotNull(entity);
            Assert.Equal(expectedEntity, entity);
        }

        [Fact]
        public void Clean_ShouldCallCleanOnRepository()
        {
            // Arrange
            var mockRepository = new Mock<IPropertyRepository>();
            var service = new EntityService(mockRepository.Object);

            // Act
            service.Clean();

            // Assert
            mockRepository.Verify(repo => repo.Clean(), Times.Once);
        }
    }
}
