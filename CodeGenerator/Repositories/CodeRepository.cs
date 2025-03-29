using CodeGenerator.Models;

namespace CodeGenerator.Repositories
{
    public interface ICodeRepository
    {
        List<CodeLanguage> GetLanguages();
        string InitialCode(string language);
        string TransformEntityToCode(Entity entity, string languaje);
    }

    public class CodeRepository : ICodeRepository
    {
        private readonly Transformers.Transformers transformers;

        public CodeRepository(Transformers.Transformers transformers)
        {
            this.transformers = transformers;
        }

        public List<CodeLanguage> GetLanguages()
        {
            return this.transformers.GetLanguages();
        }

        public string InitialCode(string language)
        {
            var transformer = transformers.GetTransformer(language);
            return transformer!.Transform(new Entity());
        }

        public string TransformEntityToCode(Entity entity, string language)
        {
            var transformer = transformers.GetTransformer(language);
            return transformer!.Transform(entity);
        }
    }
}
