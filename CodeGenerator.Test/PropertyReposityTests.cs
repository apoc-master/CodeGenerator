using CodeGenerator.Models;
using CodeGenerator.Repositories;

namespace CodeGenerator.Test
{
    public class PropertyReposityTests
    {
        [Fact]
        public void GetEntity_ShouldReturnNewEntity()
        {
            // Arrange
            var repository = new PropertyReposity();

            // Act
            var entity = repository.GetEntity();

            // Assert
            Assert.NotNull(entity);
            Assert.Equal("", entity.Name);
            Assert.NotNull(entity.Properties);
            Assert.Empty(entity.Properties);
        }

        [Fact]
        public void Clean_ShouldResetEntity()
        {
            // Arrange
            var repository = new PropertyReposity();
            var entity = repository.GetEntity();
            entity.Name = "Test";
            entity.Properties ??= []; // Ensure Properties is not null
            entity.Properties.Add(new EntityProperty { Name = "Property1", Kind = "string" });

            // Act
            repository.Clean();
            var newEntity = repository.GetEntity();

            // Assert
            Assert.NotNull(newEntity);
            Assert.Equal("", newEntity.Name);
            Assert.NotNull(newEntity.Properties);
            Assert.Empty(newEntity.Properties);
        }
    }
}