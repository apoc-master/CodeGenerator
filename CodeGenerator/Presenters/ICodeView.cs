using CodeGenerator.Models;
using System.ComponentModel;

namespace CodeGenerator.Presenters
{
    public interface ICodeView
    {
        void ShowLanguages(List<CodeLanguage> languages);
        void ShowTranformedCode(string code);

        event EventHandler LoadLanguagesEvent;
        event EventHandler<ListChangedEventArgs> TransformCodeEvent;
        event EventHandler LoadInitialCodeEvent;

        string LanguageSelected { get; }
        Entity Entity { get; }
    }
}
