namespace CodeGenerator.Models
{
    public class CodeLanguage
    {
        private readonly string _name;
        private readonly bool _default;

        public CodeLanguage(string name, bool isDefault)
        {
            _name = name;
            _default = isDefault;
        }

        public string Name => _name;
        public bool Default => _default;

        public override string ToString()
        {
            return Name;
        }
    }
}
