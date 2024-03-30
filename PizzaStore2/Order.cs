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
     
        
        
        Pizza Pizza { get; set; }
        Costumer Costumer { get; set; }
        Drink Drink { get; set; }
        Topping Topping { get; set; } 

        private int ordreId;
        DateTime date;
        private static int idcounter = 0;
        private double totalprice;

        public double Totalprice { get => totalprice * 1.25; set => totalprice = value; }
        private List<Pizza> Pizzas { get; set; }
        private List<Drink> Drinks { get; set; }
        private List<Topping> Toppings { get; set; }
        public int OrdreId { get => ordreId; set => ordreId = value; }
        public DateTime Date { get => date; private set => date = value; }


        public Order(List<Pizza> pizzas, Costumer costumer, int OrdreId, List<Drink> drinks, List<Topping> toppings)
        {
            Pizzas = pizzas;
            Costumer = costumer;
            this.OrdreId = OrdreId;
            this.Toppings = toppings;
            foreach (Topping t in toppings) { totalprice += t.Price; }
            totalprice = 0;
            foreach (Pizza p in Pizzas) { totalprice += p.Price; }
            Date = DateTime.Now;
            idcounter++;
            Drinks = drinks;
            foreach (Drink d in drinks) { totalprice += d.Price; }
            {

            }
        }


        public override string ToString()
        {
            string piz = "";
            string dri = "";
            string top = "";
            foreach (Pizza p in Pizzas) piz += p.ToString();
            foreach (Drink d in Drinks) dri += d.ToString();
            foreach (Topping t in Toppings) top += t.ToString();
            return "Ordre: " + OrdreId + "\n" + "Følgende kunde:" + "\n" + Costumer +  "Har den: " + Date.ToString("dd:MM:yy kl HH:mm:ss") + " Bestilt følgende: "
                + "\n" + piz + top + dri + "I alt at betale:".PadRight(82) + totalprice + "Kr.";
            
        }

    }

}
