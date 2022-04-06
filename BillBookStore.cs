using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class BillBookStore
    {
        int _billNo;
        int _sNo;
        string _bookName;
        int _bookPrice;
        int _quantity;
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

        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }
        public int BookPrice
        {
            get { return _bookPrice; }
            set { _bookPrice = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public BillBookStore(int billNo,int sNo,string bookName,int bookPrice,int quantity,int total)
        {
            BillNo = billNo;
            SNo = sNo;
            BookName = bookName;
            BookPrice = bookPrice;
            Quantity = quantity;
            Total = total;
        }
    }
    public class BillStoreDetail
    {
        string _shopName;
        string _shopaddress;
        long _shopContactNo;
        int _total;
        int _discount;
        int _grandTotal;

        public string ShopName
        {
            get { return _shopName; }
            set { _shopName = value; }
        }
        public string Shopaddress
        {
            get { return _shopaddress; }
            set { _shopaddress = value; }
        }

        public long ShopContactNo
        {
            get { return _shopContactNo; }
            set { _shopContactNo = value; }
        }

        public int Total
        {
            get { return _total; }
            set { _total = value; }
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
        public BillStoreDetail(string shopName, string address, long contactNo, int total, int discount, int grandTotal)
        {
            ShopName = shopName;
            Shopaddress = address;
            ShopContactNo = contactNo;
            Total = total;
            Discount = discount;
            GrandTotal = grandTotal;
        }
    }
}
