using System;
using System.Collections.Generic;
using System.Text;

namespace _06042022task
{
    class Order
    {
        public Order()
        {
            _no++;
            No = _no;
        }
        private static int _no;
        public int No { get;}
        public int ProductCount { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
