using SampleShop_Repository.Suppliers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleShop_Repository.Products
{
    public class ProductRepo : IRepository<ProductsInfo>
    {
        public IEnumerable<ProductsInfo> ShowAll()
        {
            return ProductDB.productList;
        }

        public ProductsInfo GetById(int productId)
        {
            ProductsInfo _productId = ProductDB.productList.FirstOrDefault(x => x.ProductId == productId);
            return _productId;
        }

        public void Insert(ProductsInfo productsInfo)
        {
            ProductDB.productList.Add(productsInfo);
        }

        public void Update(ProductsInfo productsInfo)
        {
            ProductsInfo _productsInfo = ProductDB.productList.FirstOrDefault(x => x.ProductId == productsInfo.ProductId);
            if(_productsInfo.ProductName != null)
            {
                _productsInfo.ProductName = productsInfo.ProductName;
            }
            else if(_productsInfo.Price != 0)
            {
                _productsInfo.Price = productsInfo.Price;
            }
            else
            {
                Console.WriteLine("Sorry!! Product ID is Invalid.......!!");
            }
        }

        public void Delete(int productId)
        {
            ProductsInfo productsInfo_ = ProductDB.productList.FirstOrDefault(x=> x.ProductId == productId);
            ProductDB.productList.Remove(productsInfo_);
        }
    }
}
