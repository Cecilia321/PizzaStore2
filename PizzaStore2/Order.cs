using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore2
{
    internal class Order
    {
     
        private int ordreId;
        
        Pizza Pizza { get; set; }
        Costumer Costumer { get; set; }
        private double totalprice;
        public double Totalprice { get => totalprice * 1.25; set => totalprice = value; }
        private List<Pizza> Pizzas { get; set; }


       /* public Order(Pizza pizza, Costumer costumer, int OrdreId)
       {
            Pizza = pizza;
            Costumer = costumer;
            ordreId = OrdreId;
            totalprice = 0;
            
        }*/

        public Order(List<Pizza> pizzas , Costumer costumer, int OrdreId)
        {
            Pizzas = pizzas;
            Costumer = costumer;
            ordreId = OrdreId;
            totalprice = 0;
            foreach (Pizza p in Pizzas) { totalprice += p.Price; }
        }


        public override string ToString()
        {
            string piz = "";
            foreach (Pizza p in Pizzas) piz += p.ToString();
            return "" + Costumer + piz + ordreId + totalprice;
        }

        //public Order()
        //{
        //}

        /* public void CreateOrder()
         {
             orderid += menuvalg;
         }*/





        /* public void TotalPrice()
         {
             double totalP = 0;
             foreach (Pizza pizza in pizzalist)
             {
                 totalp += pizza.Price;

             }

             foreach (Drink drink in drinklist)
             {
                 menu += drink.ToString();
             }

             foreach (Topping topping in toppinglist)
             {
                 menu += topping.ToString();

             }

             return menu;
         }*/

    }

}
