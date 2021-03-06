﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility.Interfaces
{
    public interface IDataMapper<T>
    {
        T Create(T item); 
        void Update(int id, T item);
        void Delete(T item);

        void DeleteById(int id);
    }
}
