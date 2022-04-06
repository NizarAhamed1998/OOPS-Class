using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class ProductRestaurant
    {
        int _productCode;
        string _productName;
        int _productUnitPrice;

        public int ProductCode
        {
           
            set { _productCode = value; }
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public int ProductUnitPrice
        {
            get { return _productUnitPrice; }
            set { _productUnitPrice = value; }
        }

        public ProductRestaurant(int prodCode,string prodName,int prodUnitPrice)
        {
            ProductCode = prodCode;
            ProductName = prodName;
            ProductUnitPrice = prodUnitPrice;
        }
    }
}
