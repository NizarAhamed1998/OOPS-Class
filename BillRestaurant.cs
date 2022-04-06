using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class BillRestaurant
    {
        int _billNo;
        DateTime _datetime;
        int _sNo;
        string _itemName;
        int _itemUnitPrice;
        int _itemQuantity;
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
        public DateTime Datetime
        {
            get { return _datetime; }
            set { _datetime = value; }
        }

        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }

        public int ItemUnitPrice
        {
            get { return _itemUnitPrice; }
            set { _itemUnitPrice = value; }
        }

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set { _itemQuantity = value; }
        }

        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public BillRestaurant(int billNo,int sNo,DateTime datetime,string itemName,int itemPrice,int itemQty)
        {
            BillNo = billNo;
            Datetime = datetime;
            SNo = sNo;
            ItemName = itemName;
            ItemUnitPrice = itemPrice;
            ItemQuantity = itemQty;
            Total = _itemUnitPrice * _itemQuantity;

        }
    }
    public class RestaurantDetail
    {
        string _restaurantName;
        string _restaurantAddress;
        long _restaurantContactNo;
        int _grandTotal;

       
        public string RestaurantName
        {
            get { return _restaurantName; }
            set { _restaurantName = value; }
        }

        public string RestaurantAddress
        {
            get { return _restaurantAddress; }
            set { _restaurantAddress = value; }
        }

        public long RestaurantContactNo
        {
            get { return _restaurantContactNo; }
            set { _restaurantContactNo = value; }
        }
        public int GrandTotal
        {
            get { return _grandTotal; }
            set { _grandTotal = value; }
        }

        public RestaurantDetail(string restaurantName,string restaurantAddress,long contactNo,int grandTotal)
        {
            RestaurantName = restaurantName;
            RestaurantAddress = restaurantAddress;
            RestaurantContactNo = contactNo;
            GrandTotal = grandTotal;
        }
    }
}
