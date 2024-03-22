using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class OrderAdministration
    {
        //private MenuCatalog menucatalog;
        //private CostumerAdministration costumeradministration;
        private List<Order> orderlist = new List<Order>();

        internal List<Order> Orderlist1 { get => orderlist; set => orderlist = value; }

        public void CreateOrder(Costumer costumer, List<Pizza> pizza, int ordreId)
        {
            Order o = new Order(pizza, costumer, ordreId);
            orderlist.Add(o);
            
        }


        //public OrderAdministration(MenuCatalog menuCatalog) 
        //{
         //   this.menucatalog = menuCatalog;
            //this.costumeradministration = costumerAdministration;
        //}
       


        public string PrintOrder()
        {
            string ol = "";
            foreach (Order order in orderlist)
            {
                ol = ol + order.ToString();
            }
            return ol;

        }

       

        

      

        /*public Order SearchOrder(string searchWord)
        {
            bool found = false;
            int index = 0;
            Order foundOrder = null;
            while (found == false && index <= orderlist.Count - 1)
            {
                if (orderlist[index].orderId.Equals(searchWord))
                {
                    found = true;
                    foundOrder = orderlist[index];
                }
                index++;
            }
            if (found == false) throw new CostumerNotFoundExeption();
            return foundCostumer;

        }

        public void DeleteCostumer(string searchWord)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= costumerlist.Count - 1)
            {
                if (costumerlist[index].Name.Equals(searchWord))
                {
                    found = true;
                    costumerlist.RemoveAt(index);
                }
                index++;
            }
            if (found == false) throw new CostumerNotFoundExeption();
        }

        public void UpdateCostumer(string name, int number)
        {
            bool found = false;
            int index = 0;
            while ((found == false) && index <= costumerlist.Count - 1)
            {
                if (costumerlist[index].Name.Equals(name))
                {
                    found = true;
                    costumerlist[index].Number = number;
                    costumerlist[index].Name = name;
                }
                index++;
            }
            if (found == false) throw new CostumerNotFoundExeption();*/
        }
}
