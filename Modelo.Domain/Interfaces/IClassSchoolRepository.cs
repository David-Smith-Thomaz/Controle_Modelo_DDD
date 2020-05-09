using Modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.Domain.Interfaces
{
    public interface IClassSchoolRepository<T> where T : ClassSchoolBase
    {
        void Insert(T obj);

        void Update(T obj);

        void Delete(int id);

        T Select(int id);

        IList<T> Select();
    }
}

