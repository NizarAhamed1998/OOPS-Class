using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Classes
{
    public class BookStore
    {
        string _language;
        string _bookCategory;
        string _bookName;
        string _authorName;
        int _bookPrice;


        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        public string BookCategory
        {
            get { return _bookCategory; }
            set { _bookCategory = value; }
        }

        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

        public string AuthorName
        {
            get { return _authorName; }
            set { _authorName = value; }
        }

        public int BookPrice
        {
            get { return _bookPrice; }
            set { _bookPrice = value; }
        }

        public BookStore(string language, string bookCategory, string bookName,string authorName,int bookPrice)
        {
            Language = language;
            BookCategory = bookCategory;
            BookName = bookName;
            AuthorName = authorName;
            BookPrice = bookPrice;
        }
    }
}
