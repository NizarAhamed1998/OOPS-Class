using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class BillMobileStore
    {
        int _billNo;
        int _sNo;
        string _modelName;
        string _imeiNo;
        int _quantity;
        int _unitPrice;
        int _total;


        public int BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }

        public int SNo
        {
            get { return _sNo; }
            set { _sNo = value; }
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

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public int UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }
        public BillMobileStore(int billNo,int sNo,string modelName,string imeiNo,int quantity,int unitPrice)
        {
            BillNo = billNo;
            SNo = sNo;
            ModelName = modelName;
            ImeiNo = imeiNo;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Total = Quantity * UnitPrice;
        }
    }
    public class BillDetail
    {
        string _shopName;

        string _address;

        long _contactNo;


        string _clientName;

        string _clientaddress;

        long _clientContactNo;


        int _total;

        int _tax;

        int _discount;

        int _grandTotal;

       

        public string ShopName
        {
            get { return _shopName; }
            set { _shopName = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public long ContactNo
        {
            get { return _contactNo; }
            set { _contactNo = value; }
        }

        public string ClientName
        {
            get { return _clientName; }
            set { _clientName = value; }
        }

        public string Clientaddress
        {
            get { return _clientaddress; }
            set { _clientaddress = value; }
        }

        public long ClientContactNo
        {
            get { return _clientContactNo; }
            set { _clientContactNo = value; }
        }

        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public int Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }

        public int Discount
        {
            get { return _discount; }
            set { _discount = value; }
        }
        public int GrandTotal
        {
            get { return _grandTotal; }
            set { _grandTotal = value; }
        }

        public BillDetail(string shopName,string address,long contactNo,string clientName,string clientaddress,long clientContactNo,int total,int tax,int discount,int grandTotal)
        {
            ShopName = shopName;
            Address = address;
            ContactNo = contactNo;
            ClientName = clientName;
            Clientaddress = clientaddress;
            ClientContactNo = clientContactNo;
            Total = total;
            Tax = tax;
            Discount = discount;
            GrandTotal = grandTotal;

        }
    }
}
