using CodeGenerator.Models;
using System.Text;

namespace CodeGenerator.Transformers
{
    public interface ITransformer
    {
        string Name { get; }
        bool Default { get; }
        string Transform(Entity entity);
    }

    public class CSharpTransformer : ITransformer
    {
        private const string NAME = "C#";
        public string Name => NAME;
        public bool Default => true;

        public string Transform(Entity entity)
        {
            StringBuilder sb = new();
            sb.Append(@"{\rtf1\ansi\deff0 {\colortbl;\red0\green0\blue0;\red0\green128\blue0;\red0\green0\blue255;\red0\green153\blue204; }");
            sb.Append(@"\cf2 /// <summary>\par");
            sb.Append(@"\cf2 /// entity\par");
            sb.Append(@"\cf2 /// <summary>\par");

            if (entity != null)
            {
                if (!string.IsNullOrEmpty(entity.Name))
                {
                    sb.Append(@"\par");
                    sb.Append($"\\cf3 public class \\cf4 {entity.Name}\\par");
                    sb.Append(@"\cf1 \{\par");

                    if (entity.Properties != null && entity.Properties.Count > 0)
                    {
                        foreach (var prop in entity.Properties)
                        {
                            if (!string.IsNullOrEmpty(prop.Name) && !string.IsNullOrEmpty(prop.Kind))
                            {
                                sb.Append($"\\tab\\cf3 public {prop.Kind} \\cf4 {prop.Name} \\cf1 \\{{ get; set; \\}}\\par");
                            }
                        }

                        sb.Append(@"\cf1 \}\par");
                    }
                }

                sb.Append(@"}");
            }
            return sb.ToString();

        }
    }
}