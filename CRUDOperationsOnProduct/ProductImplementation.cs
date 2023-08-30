using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperationsOnProduct
{
    public class ProductImplementation
    {
        private List<ProductData> productlist;

        public ProductImplementation()
        {
            productlist = new List<ProductData>()
            {
                new ProductData() {ID=1 ,Name="Book",Price=300,Company="Nirali"},
                new ProductData() {ID=2 ,Name="Mobile",Price=12000,Company="Samsung"}
            };
        }

        public List<ProductData> GetProducts()
        {
            return productlist;
        }
        public ProductData GetProductsByID(int id)
        {
            ProductData product= new ProductData();
            foreach(ProductData p in productlist)
            {
                if(p.ID==id)
                {
                    product=p;
                    break;
                }
            }
            return product;
        }

        public void ProductAdd(ProductData p)
        {
            productlist.Add(p);
        }

        public void ProductUpdate(ProductData p)
        {
            foreach(ProductData pdata in productlist)
            {
                if(pdata.ID==p.ID)
                {
                    pdata.Name=p.Name;
                    pdata.Price=p.Price;
                    pdata.Company=p.Company;
                    break;
                }
            }
        }

        public void ProductDelete(int id)
        {
            foreach(ProductData pdata in productlist)
            {
                if(pdata.ID==id)
                {
                    productlist.Remove(pdata);
                    break;
                }
            }
        }

    }
}











