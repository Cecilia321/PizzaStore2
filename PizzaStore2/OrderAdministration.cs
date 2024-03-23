using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class OrderAdministration
    {
        private List<Order> orderlist = new List<Order>();

        internal List<Order> Orderlist1 { get => orderlist; set => orderlist = value; }

        public void CreateOrder(Costumer costumer, List<Pizza> pizza, int ordreId)
        {
            Order o = new Order(pizza, costumer, ordreId);
            orderlist.Add(o);

        }

        public string PrintOrder()
        {
            string ol = "";
            foreach (Order order in orderlist)
            {
                ol = ol + order.ToString();
            }
            return ol;

        }
        public Order SearchOrder(string searchWord)
        {
            bool found = false;
            int index = 0;
            Order foundOrder = null;
            while (found == false && index <= orderlist.Count - 1)
            {
                if (orderlist[index].OrdreId.Equals(searchWord))
                {
                    found = true;
                    foundOrder = orderlist[index];
                }
                index++;
            }
            if (found == false) throw new OrderNotFoundExeption();
            return foundOrder;

        }

        public void DeleteOrder(string searchWord)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= orderlist.Count - 1)
            {
                if (orderlist[index].OrdreId.Equals(searchWord))
                {
                    found = true;
                    orderlist.RemoveAt(index);
                }
                index++;
            }
            if (found == false) throw new OrderNotFoundExeption();
        }

        public void UpdateOrder(Pizza pizza, Costumer costumer, int orderId)
        {
            bool found = false;
            int index = 0;
            while ((found == false) && index <= orderlist.Count - 1)
            {
                if (orderlist[index].OrdreId.Equals(orderId))
                {
                    found = true;
                    orderlist[index].OrdreId = orderId;
                }
                index++;
            }
            if (found == false) throw new OrderNotFoundExeption();
        }
    }
}   
