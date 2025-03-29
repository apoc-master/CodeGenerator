using CodeGenerator.Models;

namespace CodeGenerator.Test
{
    public class CodeLanguageTests
    {
        [Fact]
        public void Constructor_CreateNewCodeLanguage()
        {
            // Arrange
            var _name = "Test";
            var _default = true;

            // Act
            var codeLanguage = new CodeLanguage(_name, _default);

            // Assert
            Assert.Equal(_name, codeLanguage.Name);
            Assert.Equal(_default, codeLanguage.Default);
        }

        [Fact]
        public void ToString_ShouldReturnTheName()
        {
            // Arrange
            var _name = "Test";
            var _default = false;

            //Act
            var codeLanguage = new CodeLanguage(_name, _default);

            Assert.Equal(_name, codeLanguage.ToString());
        }
    }
}
