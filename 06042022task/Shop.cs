
using System;
using System.Collections.Generic;
using System.Text;

namespace _06042022task
{
    class Shop
    {
        List<Order> _orders;
        public Shop()
        {
            _orders = new List<Order>();
        }
        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
        public double GetOrdersAvg()
        {
            if (_orders.Count!=0)
            {
                double AveragePrice = 0;
                foreach (var order in _orders)
                {
                    AveragePrice = AveragePrice + order.TotalAmount;
                }
                return AveragePrice / _orders.Count;
            }
            return 0;
        }
        public double GetOrdersAvg(DateTime time)
        {
            var orders = _orders.FindAll(order=>order.CreatedAt > time);
            double AveragePrice = 0;
            foreach (var order in orders)
            {
                AveragePrice = AveragePrice + order.TotalAmount;
            }
            return AveragePrice / orders.Count;
        }
        public void RemoveOrderByno(int? no)
        {
            if (no==null)
            
                throw new Exception("Nulldir");
            var order = _orders.Find(order => order.No == no);
            if (order != null)
                _orders.Remove(order);
        }
        public List<Order>FilterOrderByPrice(double MaxPrice,double MinPrice)
        {
            return _orders.FindAll(order => order.TotalAmount > MinPrice && order.TotalAmount < MaxPrice);
        }
    }
}
