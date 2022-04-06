using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class BillOnlineStore
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
        public BillOnlineStore(string prodName,int prodUnitPrice,int prodQuantity,int amount)
        {
            ProductName = prodName;
            ProductUnitPrice = ProductUnitPrice;
            ProductQuantity = prodQuantity;
            Amount = amount;
        }
    }
    public class ShopAndClientDetail
    {
        string _shopName;
        string _shopAddress;
        long _shopContactNo;
        string _clientName;
        string _clientAddress;
        long _clientContactNo;
        int _totalAmount;



        public string ShopName
        {
            get { return _shopName; }
            set { _shopName = value; }
        }

        public string ShopAddress
        {
            get { return _shopAddress; }
            set { _shopAddress = value; }
        }

        public long ShopContactNo
        {
            get { return _shopContactNo; }
            set { _shopContactNo = value; }
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

        public int TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
        public ShopAndClientDetail(string shopName,string address,long contactNo,string clientName,string clientAddress,long clientContactNo,int total)
        {
            ShopName = shopName;
            ShopAddress = address;
            ShopContactNo = contactNo;
            ClientName = clientName;
            ClientAddress = clientAddress;
            ClientContactNo = clientContactNo;
            TotalAmount = total;
        }
    }
}
