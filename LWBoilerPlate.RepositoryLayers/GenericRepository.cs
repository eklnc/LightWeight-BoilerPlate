using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LWBoilerPlate.Models.Entities;
using LWBoilerPlate.RepositoryContracts;

namespace LWBoilerPlate.RepositoryLayers
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private LWBoilerPlateContext _dbEntities;
        private DbSet<T> _dbEntity;

        private void SetDbParameters()
        {
            _dbEntities = LWBoilerPlateContext.GetContext();

            if (_dbEntities != null)
            {
                _dbEntity = _dbEntities.Set<T>();
            }
        }

        public void Insert(T entity)
        {
            SetDbParameters();

            _dbEntity.Add(entity);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool GetByEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
