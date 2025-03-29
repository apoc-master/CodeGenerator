using CodeGenerator.Models;
using CodeGenerator.Presenters;
using CodeGenerator.Services;
using Moq;
using System.ComponentModel;

namespace CodeGenerator.Test
{
    public class CodePresenterTests
    {
        [Fact]
        public void OnLoadLanguagesEvent_ShouldShowLanguages()
        {
            // Arrange
            var viewMock = new Mock<ICodeView>();
            var serviceMock = new Mock<ICodeService>();
            var languajes = new List<CodeLanguage>
            {
                new("C#", true),
                new("Phyton", false)
            };

            serviceMock.Setup(s => s.GetLanguages()).Returns(languajes);

            var presenter = new CodePresenter(viewMock.Object, serviceMock.Object);

            // Act
            viewMock.Raise(v => v.LoadLanguagesEvent += null, EventArgs.Empty);

            // Assert
            viewMock.Verify(v => v.ShowLanguages(languajes), Times.Once());
        }

        [Fact]
        public void OnTransformCodeEvent_ShouldShowTransformedCode()
        {
            // Arrange
            var viewMock = new Mock<ICodeView>();
            var serviceMock = new Mock<ICodeService>();
            var entity = new Entity { Name = "TestEntity" };
            var transformedCode = "Transformed Code";

            viewMock.Setup(v => v.Entity).Returns(entity);
            viewMock.Setup(v => v.LanguageSelected).Returns("C#");
            serviceMock.Setup(s => s.TransformEntityToCode(entity, "C#")).Returns(transformedCode);

            var presenter = new CodePresenter(viewMock.Object, serviceMock.Object);

            // Act
            viewMock.Raise(v => v.TransformCodeEvent += null, new ListChangedEventArgs(ListChangedType.ItemAdded, 0));

            // Assert
            viewMock.Verify(v => v.ShowTranformedCode(transformedCode), Times.Once());
        }

        [Fact]
        public void OnLoadInitialCodeEvent_ShouldShowInitialCode()
        {
            // Arrange
            var viewMock = new Mock<ICodeView>();
            var serviceMock = new Mock<ICodeService>();
            var initialCode = "Initial Code";

            viewMock.Setup(v => v.LanguageSelected).Returns("C#");
            serviceMock.Setup(v => v.InitialCode("C#")).Returns(initialCode);

            var presernter = new CodePresenter(viewMock.Object, serviceMock.Object);

            // Act
            viewMock.Raise(v => v.LoadInitialCodeEvent += null, EventArgs.Empty);

            // Asset
            viewMock.Verify(v => v.ShowTranformedCode(initialCode), Times.Once());
        }
    }
}
