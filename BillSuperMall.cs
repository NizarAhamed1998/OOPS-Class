using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class BillSuperMall
    {

        string _productName;
        int _productUnitPrice;
        int _productQuantity;
        int _amount;
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

        public int ProductQuantity
        {
            get { return _productQuantity; }
            set { _productQuantity = value; }
        }
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public BillSuperMall(string prodName,int prodUnitPrice,int prodQuantity,int amount)
        {
            ProductName = prodName;
            ProductUnitPrice = ProductUnitPrice;
            ProductQuantity = prodQuantity;
            Amount = amount;
        }
    }
}
