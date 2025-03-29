using CodeGenerator.Models;

namespace CodeGenerator.Transformers
{
    public class Transformers
    {
        private List<ITransformer> tranformers;

        public Transformers()
        {
            List<ITransformer> transformers = new()
                {
                    new CSharpTransformer()
                };

            tranformers = transformers;
        }

        public virtual List<CodeLanguage> GetLanguages()
        {
            return tranformers.Select(t => new CodeLanguage(t.Name, t.Default)).ToList();
        }

        public virtual ITransformer? GetTransformer(string name)
        {
            return tranformers.SingleOrDefault(t => t.Name == name);
        }
    }
}
