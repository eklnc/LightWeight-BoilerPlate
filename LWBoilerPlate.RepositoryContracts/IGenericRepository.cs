using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWBoilerPlate.RepositoryContracts
{
    public interface IGenericRepository<T>  where T : class
    {
        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        T GetById(int id);

        List<T> GetAll();

        bool GetByEntity(T entity);
    }
}
