using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Domain.Repositories
{
    public interface IRepo<T> where T : class
    {
        List<T> getAll();
        T Get(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
