using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    public interface IRepository <T> where T: Entity
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
    }
}
