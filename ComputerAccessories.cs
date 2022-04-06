using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class ComputerAccessories
    {
        string _brandName;
        string _modelName;
        int _unitPrice;
        DateTime _importMonth;
        DateTime _mfgMonth;

      

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

        public int UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        public DateTime ImportMonth
        {
            get { return _importMonth; }
            set { _importMonth = value; }
        }
        public DateTime MfgMonth
        {
            get { return _mfgMonth; }
            set { _mfgMonth = value; }
        }

        public ComputerAccessories(string brandName,string modelName,int unitPrice,DateTime importMonth,DateTime mfgMonth)
        {
            BrandName = brandName;
            ModelName = modelName;
            UnitPrice = unitPrice;
            ImportMonth = importMonth;
            MfgMonth = mfgMonth;
        }
    }
}
