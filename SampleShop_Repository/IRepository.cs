using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleShop_Repository.Suppliers
{
    public interface IRepository<T>
    {
        IEnumerable<T> ShowAll();
        T GetById(int supplierId);
        void Insert(T suppInfo);
        void Update(T suppInfo);
        void Delete(int supplierId);
    }
}
