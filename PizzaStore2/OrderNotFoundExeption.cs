using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class OrderNotFoundExeption : Exception
    {
        public OrderNotFoundExeption() : base("Order not found")
        {

        }

        public OrderNotFoundExeption(string message) : base(message)
        {

        }
    }
}
