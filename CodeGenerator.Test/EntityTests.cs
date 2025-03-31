using CodeGenerator.Models;
using System.ComponentModel;

namespace CodeGenerator.Test
{
    public class EntityTests
    {
        [Fact]
        public void Entity_ShouldInitializeWithDefaultValue()
        {
            // Arrange
            Entity entity = new();

            // Assert
            Assert.Equal(string.Empty, entity.Name);
            Assert.Null(entity.Properties);
        }

        [Fact]
        public void Entity_ShouldSubscribeToListChangedEvent()
        {
            // Assert
            Entity entity = new()
            {
                Properties = []
            };

            bool eventTriggered = false;
            void handler(object? sender, ListChangedEventArgs e) => eventTriggered = true;

            // Act
            entity.SubscribeToListChanged(handler);
            entity.Properties.Add(new EntityProperty());

            // Assert
            Assert.True(eventTriggered);
        }
    }

    public class EntityPropertyTests
    {
        [Fact]
        public void EntityProperty_ShouldInitializeWithDefaultValues()
        {
            // Arrange
            var property = new EntityProperty();

            // Assert
            Assert.Equal(string.Empty, property.Name);
            Assert.Equal(string.Empty, property.Kind);
        }

    }
}
