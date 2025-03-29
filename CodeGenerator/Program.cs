using CodeGenerator.Presenters;
using CodeGenerator.Repositories;
using CodeGenerator.Services;

namespace CodeGenerator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            IPropertyRepository propertyRepository = new PropertyReposity();
            IEntityService entityService = new EntityService(propertyRepository);

            Transformers.Transformers transformers = new();

            ICodeRepository codeRepository = new CodeRepository(transformers);
            ICodeService codeService = new CodeService(codeRepository);

            App form = new();

            PropertyPresenter propertyPresenter = new(form, entityService);

            CodePresenter codePresenter = new(form, codeService);

            Application.Run(form);
        }
    }
}