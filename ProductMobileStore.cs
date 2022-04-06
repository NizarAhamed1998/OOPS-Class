using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class ProductMobileStore
    {
        string _brandName;
        string _modelName;
        string _imeiNo;
        int _unitPrice;

       
        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; }
        }

        public string ModelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }

        public string ImeiNo
        {
            get { return _imeiNo; }
            set { _imeiNo = value; }
        }
        public int UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        public ProductMobileStore(string brandName,string modelName,string imeiNo,int unitPrice)
        {
            BrandName = brandName;
            ModelName = modelName;
            ImeiNo = imeiNo;
            UnitPrice = unitPrice;
        }
    }
}
