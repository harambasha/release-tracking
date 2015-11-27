using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleaseTracker.Service.Common
{
    public interface IRepository<T>
    {
        long Insert(T entity);
        T Update(T entity);
        T Delete(long id);
        List<T> GetAll();
        T GetById(long id);
    }
}