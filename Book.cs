using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWarehouse
{
    class Book
    {
        public string _title {  get; set; }
        public string _author { get; set; }
        public double _price { get; set; }
        public int _count { get; set; }
        public int _sales { get; set; }
        public double _profit { get; set; }

        public Book(string _title, string _author, double _price, int _count, int sales, double profit)
        {
            this._title = _title;
            this._author = _author;
            this._price = _price;
            this._count = _count;
            this._sales = sales;
            this._profit = profit;
        }

        public Book() { }
    }
}
