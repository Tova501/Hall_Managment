using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hall.Core.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T? GetById(int id);

        bool Add(T entity);

        bool Update(int id, T entity);

        bool Delete(int id);
    }
}
