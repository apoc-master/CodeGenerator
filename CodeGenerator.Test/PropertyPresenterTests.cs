using CodeGenerator.Models;
using CodeGenerator.Presenters;
using CodeGenerator.Services;
using Moq;

namespace CodeGenerator.Test
{
    public class PropertyPresenterTests
    {
        [Fact]
        public void OnLoadEvent_ShouldLoadAndShowEntity()
        {
            // Arrange
            var mockView = new Mock<IPropertyView>();
            var mockService = new Mock<IEntityService>();
            var expectedEntity = new Entity
            {
                Name = "TestEntity",
                Properties = []
            };
            mockService.Setup(service => service.GetEntity()).Returns(expectedEntity);

            var presenter = new PropertyPresenter(mockView.Object, mockService.Object);

            // Act
            mockView.Raise(view => view.LoadPropertiesEvent += null, EventArgs.Empty);

            // Assert
            mockService.Verify(service => service.GetEntity(), Times.Once);
            mockView.Verify(view => view.ShowEntity(expectedEntity), Times.Once);
        }

        [Fact]
        public void OnCleanEvent_ShouldCleanAndShowEntity()
        {
            // Arrange
            var mockView = new Mock<IPropertyView>();
            var mockService = new Mock<IEntityService>();
            var expectedEntity = new Entity
            {
                Name = "TestEntity",
                Properties = []
            };
            mockService.Setup(service => service.GetEntity()).Returns(expectedEntity);

            var presenter = new PropertyPresenter(mockView.Object, mockService.Object);

            // Act
            mockView.Raise(view => view.CleanPropertiesEvent += null, EventArgs.Empty);

            // Assert
            mockService.Verify(service => service.Clean(), Times.Once);
            mockService.Verify(service => service.GetEntity(), Times.Once);
            mockView.Verify(view => view.ShowEntity(expectedEntity), Times.Once);
        }
    }
}
