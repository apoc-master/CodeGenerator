using CodeGenerator.Models;
using CodeGenerator.Repositories;

namespace CodeGenerator.Services
{
    public interface ICodeService
    {
        List<CodeLanguage> GetLanguages();
        string InitialCode(string language);
        string TransformEntityToCode(Entity entity, string languaje);
    }

    public class CodeService : ICodeService
    {
        private readonly ICodeRepository repository;

        public CodeService(ICodeRepository repository)
        {
            this.repository = repository;
        }

        public List<CodeLanguage> GetLanguages()
        {
            return repository.GetLanguages();
        }

        public string TransformEntityToCode(Entity entity, string languaje)
        {
            return repository.TransformEntityToCode(entity, languaje);
        }

        public string InitialCode(string language)
        {
            return repository.InitialCode(language);
        }
    }
}
