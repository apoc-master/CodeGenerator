using CodeGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Presenters
{
    public interface IPropertyView
    {
        Entity Entity { get; }

        void ShowEntity(Entity entity);

        event EventHandler LoadPropertiesEvent;
        event EventHandler CleanPropertiesEvent;
    }
}
