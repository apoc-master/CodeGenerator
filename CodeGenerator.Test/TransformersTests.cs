using CodeGenerator.Transformers;
using Moq;

namespace CodeGenerator.Test
{
    public class TransformersTests
    {
        [Fact]
        public void GetLanguages_ShouldReturnListOfLanguages()
        {
            // Arrange
            var transformersMock = new Mock<Transformers.ITransformer>();
            transformersMock.Setup(t => t.Name).Returns("C#");
            transformersMock.Setup(t => t.Default).Returns(true);

            var transformers = new Transformers.Transformers();
            transformers.GetType()
                .GetField("Trasnformers", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(transformers, new List<ITransformer> { transformersMock.Object });

            // Act
            var result = transformers.GetLanguages();

            // Assert
            Assert.Single(result);
            Assert.Equal("C#", result[0].Name);
            Assert.True(result[0].Default);
        }

        [Fact]
        public void GetTransformer_ShouldReturnCorrectTransformer()
        {
            // Arrange
            var transformerMock = new Mock<Transformers.ITransformer>();
            transformerMock.Setup(t => t.Name).Returns("C#");

            var transformers = new Transformers.Transformers();
            transformers.GetType()
                 .GetField("tranformers", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(transformers, new List<ITransformer> { transformerMock.Object });

            // Act
            var result = transformers.GetTransformer("C#");

            // Arrange
            Assert.NotNull(result);
            Assert.Equal("C#", result!.Name);
        }

        [Fact]
        public void GetTransformer_ShouldReturnNullForUnknownTransformer()
        {
            // Arrange
            var transformerMock = new Mock<ITransformer>();
            transformerMock.Setup(t => t.Name).Returns("C#");

            var transformers = new Transformers.Transformers();
            transformers.GetType()
                .GetField("tranformers", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.SetValue(transformers, new List<ITransformer> { transformerMock.Object });

            // Act
            var result = transformers.GetTransformer("Java");

            // Assert
            Assert.Null(result);
        }
    }
}
