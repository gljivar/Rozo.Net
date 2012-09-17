using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility.Interfaces
{
    public interface IRepository<T> : IDataMapper<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
