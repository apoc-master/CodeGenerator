using CodeGenerator.Models;
using CodeGenerator.Presenters;
using System.ComponentModel;

namespace CodeGenerator
{
    /// <summary>
    /// Application form
    /// </summary>
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public partial class App : Form, IPropertyView, ICodeView
    {
        /// <summary>
        /// Application Initilizer
        /// </summary>
        public App()
        {
            InitializeComponent();
            LoadPropertiesEvent = delegate { };
            CleanPropertiesEvent = delegate { };
            LoadLanguagesEvent = delegate { };
            TransformCodeEvent = delegate { };
            LoadInitialCodeEvent = delegate { };
        }

        private Entity entity;

        public event EventHandler LoadPropertiesEvent;
        public event EventHandler CleanPropertiesEvent;
        public event EventHandler LoadLanguagesEvent;
        public event EventHandler<ListChangedEventArgs> TransformCodeEvent;
        public event EventHandler LoadInitialCodeEvent;

        public string LanguageSelected => CodeLanguageComboBox.Text;

        public Entity Entity => entity;

        void IPropertyView.ShowEntity(Entity entity)
        {
            this.entity = entity;

            EntityNameText.Text = this.entity.Name;
            PropertiesGrid.DataSource = null;
            if (this.entity.Properties != null)
            {
                PropertiesGrid.DataSource = this.entity.Properties;
                this.entity.SubscribeToListChanged(Properties_ListChanged);
            }
        }

        void ICodeView.ShowLanguages(List<CodeLanguage> languages)
        {
            CodeLanguageComboBox.DataSource = languages;
            CodeLanguageComboBox.DisplayMember = "Name";

            CodeLanguage? languageDefault = languages.FirstOrDefault(lang => lang.Default);

            if (languageDefault != null)
            {
                CodeLanguageComboBox.SelectedItem = languageDefault;
            }
        }

        private void Properties_ListChanged(object? sender, ListChangedEventArgs e)
        {
            TransformCodeEvent?.Invoke(this, e);
        }

        public void ShowTranformedCode(string code)
        {
            CodeText.Rtf = code;
        }

        private void App_Load(object sender, EventArgs e)
        {
            LoadPropertiesEvent?.Invoke(this, EventArgs.Empty);
            LoadLanguagesEvent?.Invoke(this, EventArgs.Empty);
            LoadInitialCodeEvent?.Invoke(this, EventArgs.Empty);
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            CleanPropertiesEvent?.Invoke(this, EventArgs.Empty);
            LoadInitialCodeEvent?.Invoke(this, EventArgs.Empty);
        }

        private void EntityNameText_TextChanged(object sender, EventArgs e)
        {
            this.entity.Name = EntityNameText.Text;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CodeText.Text);
        }
    }
}
