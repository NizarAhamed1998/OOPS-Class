using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class BillComputerAccessories
    {
        int _billNo;

        string _serialNo;

        string _itemDescription;

        int _quantity;

        string _warranty;

        int _unitPrice;

        int _total;


        public int BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }

        public string SerialNo
        {
            get { return _serialNo; }
            set { _serialNo = value; }
        }

        public string ItemDescription
        {
            get { return _itemDescription; }
            set { _itemDescription = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string Warranty
        {
            get { return _warranty; }
            set { _warranty = value; }
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

        public BillComputerAccessories(int billNo,string serialNo,string description,int qty,string warranty,int price)
        {
            BillNo = billNo;
            SerialNo = serialNo;
            ItemDescription = description;
            Quantity = qty;
            Warranty = warranty;
            UnitPrice = price;
            Total = Quantity * UnitPrice;

        }
    }
    public class ShopDetail
    {
        string _shopName;
        string _address;
        long _contactNo;
        string _shopEmail;
        string _clientName;
        string _clientAddress;
        long _clientContactNo;
        string _clientEmail;
        int _total;
        double _tax;
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
        public string ShopEmail
        {
            get { return _shopEmail; }
            set { _shopEmail = value; }
        }

        public string ClientName
        {
            get { return _clientName; }
            set { _clientName = value; }
        }

        public string ClientAddress
        {
            get { return _clientAddress; }
            set { _clientAddress = value; }
        }

        public long ClientContactNo
        {
            get { return _clientContactNo; }
            set { _clientContactNo = value; }
        }

        public string ClientEmail
        {
            get { return _clientEmail; }
            set { _clientEmail = value; }
        }

        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }
        public double Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }

        public int GrandTotal
        {
            get { return _grandTotal; }
            set { _grandTotal = value; }
        }

        public ShopDetail(string name,string address,long contactNo,string emailId,string clientName,string clientaddress,long clientContactNo,string clientEmail,
            int total,double tax,int grandTotal)
        {
            ShopName = name;
            Address = address;
            ContactNo = contactNo;
            ShopEmail = emailId;
            ClientName = clientName;
            ClientAddress = clientaddress;
            ClientContactNo = clientContactNo;
            ClientEmail = clientEmail;
            Total = total;
            Tax = tax;
            GrandTotal = grandTotal;
        }
    }
}
