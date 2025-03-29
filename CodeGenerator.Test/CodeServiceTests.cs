using CodeGenerator.Models;
using CodeGenerator.Repositories;
using CodeGenerator.Services;
using Moq;

namespace CodeGenerator.Test
{
    public class CodeServiceTests
    {
        [Fact]
        public void GetLanguages_ShouldReturnListOfLanguages()
        {
            // Arrange
            var repositoryMock = new Mock<ICodeRepository>();
            var languages = new List<CodeLanguage>
            {
                new("C#", true),
                new("Phyton", false)
            };
            repositoryMock.Setup(r => r.GetLanguages()).Returns(languages);

            var service = new CodeService(repositoryMock.Object);

            // Act
            var result = service.GetLanguages();

            // Assert
            Assert.Equal(languages, result);
        }

        [Fact]
        public void TransformEntityToCode_ShouldReturnTransformedCode()
        {
            // Arrange
            var repositoryMock = new Mock<ICodeRepository>();
            var entity = new Entity { Name = "TestEntity" };
            var transformCode = "Transformed Code";

            repositoryMock.Setup(r => r.TransformEntityToCode(entity, "C#")).Returns(transformCode);

            var service = new CodeService(repositoryMock.Object);

            // Act
            var result = service.TransformEntityToCode(entity, "C#");

            // Assert
            Assert.Equal(transformCode, result);
        }

        [Fact]
        public void InitialCode_ShouldReturnInitialCode()
        {
            // Arrange
            var repositoryMock = new Mock<ICodeRepository>();
            var initialCode = "Initial Code";

            repositoryMock.Setup(r => r.InitialCode("C#")).Returns(initialCode);

            var service = new CodeService(repositoryMock.Object);

            // Act
            var result = service.InitialCode("C#");

            // Assert
            Assert.Equal(initialCode, result);
        }
    }
}
