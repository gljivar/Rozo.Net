using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility.Interfaces
{
    public interface IDataMapper<T>
    {
        void Create(T item);
        void Update(T item);
        void Delete(T item);

        void DeleteById(int id);
    }
}
