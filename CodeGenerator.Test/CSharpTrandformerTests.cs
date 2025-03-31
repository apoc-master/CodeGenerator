using CodeGenerator.Models;
using CodeGenerator.Transformers;

namespace CodeGenerator.Test
{
    public class CSharpTransformerTests
    {
        [Fact]
        public void Transform_ShouldReturnFormattedCode_ForEntityWithProperties()
        {
            // Arrange
            var entity = new Entity
            {
                Name = "TestEntity",
                Properties =
                [
                    new() { Name = "Id", Kind = "int" },
                    new() { Name = "Name", Kind = "string" }
                ]
            };

            var transformer = new CSharpTransformer();

            // Act
            var result = transformer.Transform(entity);

            // Assert
            var expected = @"{\rtf1\ansi\deff0 {\colortbl;\red0\green0\blue0;\red0\green128\blue0;\red0\green0\blue255;\red0\green153\blue204; }\cf2 /// <summary>\par\cf2 /// entity\par\cf2 /// <summary>\par\par\cf3 public class \cf4 TestEntity\par\cf1 \{\par\tab\cf3 public int \cf4 Id \cf1 \{ get; set; \}\par\tab\cf3 public string \cf4 Name \cf1 \{ get; set; \}\par\cf1 \}\par}";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Transform_ShouldReturnFormattedCode_ForEntityWithoutProperties()
        {
            // Arrange
            var entity = new Entity
            {
                Name = "TestEntity",
                Properties = []
            };

            var transformer = new CSharpTransformer();

            // Act
            var result = transformer.Transform(entity);

            // Assert
            var expected = @"{\rtf1\ansi\deff0 {\colortbl;\red0\green0\blue0;\red0\green128\blue0;\red0\green0\blue255;\red0\green153\blue204; }\cf2 /// <summary>\par\cf2 /// entity\par\cf2 /// <summary>\par\par\cf3 public class \cf4 TestEntity\par\cf1 \{\par}";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Transform_ShouldReturnFormattedCode_ForEntityWithNullProperties()
        {
            // Arrange
            var entity = new Entity
            {
                Name = "TestEntity",
                Properties = null
            };

            var transformer = new CSharpTransformer();

            // Act
            var result = transformer.Transform(entity);

            // Assert
            var expected = @"{\rtf1\ansi\deff0 {\colortbl;\red0\green0\blue0;\red0\green128\blue0;\red0\green0\blue255;\red0\green153\blue204; }\cf2 /// <summary>\par\cf2 /// entity\par\cf2 /// <summary>\par\par\cf3 public class \cf4 TestEntity\par\cf1 \{\par}";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Transform_ShouldReturnFormattedCode_ForNullEntity()
        {
            // Arrange
            Entity? entity = null;

            var transformer = new CSharpTransformer();

            // Act
            var result = transformer.Transform(entity!);

            // Assert
            var expected = @"{\rtf1\ansi\deff0 {\colortbl;\red0\green0\blue0;\red0\green128\blue0;\red0\green0\blue255;\red0\green153\blue204; }\cf2 /// <summary>\par\cf2 /// entity\par\cf2 /// <summary>\par";
            Assert.Equal(expected, result);
        }
    }
}

