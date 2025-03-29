using CodeGenerator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Repositories
{

    public interface IPropertyRepository
    {
        Entity GetEntity();
        void Clean();
    }

    /// <summary>
    /// Start the Properties in memory
    /// </summary>
    public class PropertyReposity : IPropertyRepository
    {
        private Entity entity;

        public PropertyReposity()
        {
            entity = CreateNewEntity();
        }

        private Entity CreateNewEntity()
        {
            return new Entity
            {
                Name = "",
                Properties = new BindingList<EntityProperty>() { }
            };
        }

        public Entity GetEntity()
        {
            return entity;
        }

        public void Clean()
        {
            entity = CreateNewEntity();
        }

        
    }
}
