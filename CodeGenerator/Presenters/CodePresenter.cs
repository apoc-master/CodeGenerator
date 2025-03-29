using CodeGenerator.Services;
using System.ComponentModel;

namespace CodeGenerator.Presenters
{
    public class CodePresenter
    {
        private readonly ICodeView view;
        private readonly ICodeService service;

        public CodePresenter(ICodeView view, ICodeService service)
        {
            this.view = view;
            this.service = service;

            this.view.LoadLanguagesEvent += OnLoadLanguagesEvent;
            this.view.TransformCodeEvent += OnTransformCodeEvent;
            this.view.LoadInitialCodeEvent += OnLoadInitialCodeEvent;
        }

        private void OnLoadLanguagesEvent(object? sender, EventArgs e)
        {
            var languages = service.GetLanguages();
            view.ShowLanguages(languages);
        }

        private void OnTransformCodeEvent(object? sender, ListChangedEventArgs e)
        {
            var codeTransformed = service.TransformEntityToCode
                (
                    this.view.Entity,
                    this.view.LanguageSelected
                );

            view.ShowTranformedCode(codeTransformed);
        }

        private void OnLoadInitialCodeEvent(object? sender, EventArgs e)
        {
            var initialCode = service.InitialCode(this.view.LanguageSelected);
            view.ShowTranformedCode(initialCode);
        }

    }
}
