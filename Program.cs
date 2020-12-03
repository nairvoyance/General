using System;
using System.Collections.Generic;

namespace LazyLoadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer o = new Customer();
            Console.WriteLine(o.CustomerName);
            foreach (Order o1 in o.Orders)
            {
                Console.WriteLine(o1.OrderNumber);
            }
        }
    }

    public class Customer
    {
        public Customer()
        {
            _CustomerName = "Saurabh";
            _Order = LoadOrder();
        }

        private List<Order> _Order = null;
        public List<Order> Order
        {
            get
            {
                return _Order;
            }
        }


    }
}
