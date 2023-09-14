using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleShop_Repository.Suppliers
{
    public class SupplierRepo : IRepository<SupplierInfo>
    {
        public IEnumerable<SupplierInfo> ShowAll()
        {
            return SupplierDB.SupplierList;
        }


        public SupplierInfo GetById(int supplierId)
        {
            SupplierInfo supplier = SupplierDB.SupplierList.FirstOrDefault(x => x.SupplierId == supplierId);
            return supplier;
        }

        public void Insert(SupplierInfo suppInfo)
        {
            SupplierDB.SupplierList.Add(suppInfo);
        }

        public void Update(SupplierInfo suppInfo)
        {
            SupplierInfo _supplier = SupplierDB.SupplierList.FirstOrDefault(x => x.SupplierId == suppInfo.SupplierId);
            if(_supplier.CompanyName != null)
            {
                _supplier.CompanyName = suppInfo.CompanyName;
            }
            else if(_supplier.Contact != null)
            {
                _supplier.Contact = suppInfo.Contact;
            }
            else
            {
                Console.WriteLine("Sorry! Supplier ID is Invalid.!!");
            }
        }

        public void Delete(int supplierId)
        {
            SupplierInfo supplier_ = SupplierDB.SupplierList.FirstOrDefault(x => x.SupplierId ==supplierId);
            SupplierDB.SupplierList.Remove(supplier_);
        }
    }
}
