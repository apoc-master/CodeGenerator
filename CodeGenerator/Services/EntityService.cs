using CodeGenerator.Models;
using CodeGenerator.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Services
{

    public interface IEntityService
    {
        Entity GetEntity();
        void Clean();
    }

    public class EntityService : IEntityService
    {
        private readonly IPropertyRepository repository;

        public EntityService(IPropertyRepository repository)
        {
            this.repository = repository;
        }

        public Entity GetEntity()
        {
            return repository.GetEntity();
        }

        public void Clean()
        {
            repository.Clean();
        }
    }
}
