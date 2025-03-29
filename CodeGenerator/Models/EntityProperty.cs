using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Models
{
    public class Entity
    {
        public string Name { get; set; } = string.Empty;
        public BindingList<EntityProperty>? Properties { get; set; } = null;
        public void SubscribeToListChanged(ListChangedEventHandler handler)
        {
            if (Properties != null)
            {
                Properties.ListChanged += handler;
            }
        }
    }


    public class EntityProperty
    {        
        public string Name { get; set; } = string.Empty;
        public string Kind { get; set; } = string.Empty;
    }
}
