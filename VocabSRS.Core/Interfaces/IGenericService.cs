using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VocabSRS.Core.Entities;

namespace VocabSRS.Core.Interfaces
{
    public interface IGenericService<T> where T : BaseEntity
    {
        void Add(T entity);
        T Get(int id);
        List<T> GetAll();
        void Update(T entity);
        void SoftDelete(int id);
        void HardDelete(int id);
    }
}
