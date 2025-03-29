using CodeGenerator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Presenters
{
    public class PropertyPresenter
    {
        private readonly IPropertyView view;
        private readonly IEntityService service;

        public PropertyPresenter(IPropertyView view, IEntityService service)
        {
            this.view = view;
            this.service = service;

            this.view.LoadPropertiesEvent += OnLoadEvent;
            this.view.CleanPropertiesEvent += OnCleanEvent;
        }

        private void OnLoadEvent(object? sender, EventArgs e)
        {
            LoadAndShowEntity();
        }

        private void OnCleanEvent(object? sender, EventArgs e) 
        {
            service.Clean();
            LoadAndShowEntity();
        }

        private void LoadAndShowEntity()
        {
            var entity = service.GetEntity();
            view.ShowEntity(entity);
        }
        
    }
}
