using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class ProductDetailSuperMall
    {
        string _productCategory;
        string _productBrandName;
        int _productCode;
        string _productName;
        int _unitPrice;
        int _dateOfPackage;
        int _dateOfExpiry;

       
        public string ProductCategory
        {
            get { return _productCategory; }
            set { _productCategory = value; }
        }

        public string ProductBrandName
        {
            get { return _productBrandName; }
            set { _productBrandName = value; }
        }

        public int ProductCode
        {
            get { return _productCode; }
            set { _productCode = value; }
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public int UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        public int DateOfPackage
        {
            get { return _dateOfPackage; }
            set { _dateOfPackage = value; }
        }
        public int DateOfExpiry
        {
            get { return _dateOfExpiry; }
            set { _dateOfExpiry = value; }
        }

        public ProductDetailSuperMall(string prodCategory,string brandName,int prodCode,string prodName,int unitPrice,int dop,int doe)
        {
            ProductCategory = prodCategory;
            ProductBrandName = brandName;
            ProductCode = prodCode;
            ProductName = prodName;
            UnitPrice = unitPrice;
            DateOfPackage = dop;
            DateOfExpiry = doe;
        }
    }
}
