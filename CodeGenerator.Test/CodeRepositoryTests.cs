using CodeGenerator.Models;
using CodeGenerator.Repositories;
using Moq;

namespace CodeGenerator.Test
{
    public class CodeRepositoryTests
    {
        [Fact]
        public void GetLanguages_ShouldReturnListOfLanguages()
        {
            // Arrange
            var mockTransformers = new Mock<Transformers.Transformers>();
            var languages = new List<CodeLanguage>
            {
                new("C#", true),
                new("Java", false)
            };

            mockTransformers.Setup(t => t.GetLanguages()).Returns(languages);

            var repository = new CodeRepository(mockTransformers.Object);

            // Act
            var result = repository.GetLanguages();

            // Assert
            Assert.Equal(languages, result);
        }

        [Fact]
        public void InitialCode_ShouldReturnTransformedCode()
        {
            // Arrange
            var mockTransformer = new Mock<Transformers.ITransformer>();
            mockTransformer.Setup(t => t.Transform(It.IsAny<Entity>())).Returns("Transformed Code");

            var mockTransformers = new Mock<Transformers.Transformers>();
            mockTransformers.Setup(t => t.GetTransformer(It.IsAny<string>())).Returns(mockTransformer.Object);

            var repository = new CodeRepository(mockTransformers.Object);

            // Act
            var result = repository.InitialCode("C#");

            // Assert
            Assert.Equal("Transformed Code", result);
        }

        [Fact]
        public void TransformEntityToCode_ShouldReturnTransformedCode()
        {
            // Arrange
            var entity = new Entity { Name = "TestEntity" };
            var mockTransformer = new Mock<Transformers.ITransformer>();
            mockTransformer.Setup(t => t.Transform(entity)).Returns("Transformed Entity Code");

            var mockTransformers = new Mock<Transformers.Transformers>();
            mockTransformers.Setup(t => t.GetTransformer(It.IsAny<string>())).Returns(mockTransformer.Object);

            var repository = new CodeRepository(mockTransformers.Object);

            // Act
            var result = repository.TransformEntityToCode(entity, "C#");

            // Assert
            Assert.Equal("Transformed Entity Code", result);
        }
    }
}
