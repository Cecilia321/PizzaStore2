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
        private List<Topping> toppinglist;
        private List<Pizza> pizzalists;

        internal List<Order> Orderlist1 { get => orderlist; set => orderlist = value; }
        internal List<Topping> Toppinglist { get => toppinglist; set => toppinglist = value; }
        internal List<Pizza> Pizzalists { get => pizzalists; set => pizzalists = value; }

        public void CreateOrder(Costumer costumer, List<Pizza> pizza, List<Drink> drinks, int ordreId, List<Topping> topping)
        {
            Order o = new Order(pizza, costumer, ordreId, drinks, topping);
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

        public Order SearchOrder(int searchWord)
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


        public void DeleteOrder(int searchWord)
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
