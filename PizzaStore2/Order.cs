﻿using System;
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
        DateTime date;
        private static int idcounter = 0;
        
        Pizza Pizza { get; set; }
        Costumer Costumer { get; set; }
        private double totalprice;
        public double Totalprice { get => totalprice * 1.25; set => totalprice = value; }
        private List<Pizza> Pizzas { get; set; }
        public int OrdreId { get => ordreId; set => ordreId = value; }
        public DateTime Date { get => date; private set => date = value; }

        public Order(List<Pizza> pizzas , Costumer costumer, int OrdreId)
        {
            Pizzas = pizzas;
            Costumer = costumer;
            this.OrdreId = OrdreId;
            totalprice = 0;
            foreach (Pizza p in Pizzas) { totalprice += p.Price; }
            Date = DateTime.Now;
            idcounter++;
        }


        public override string ToString()
        {
            string piz = "";
            foreach (Pizza p in Pizzas) piz += p.ToString();
            return "Ordre: " + OrdreId + "\n" + "Følgende kunde:" + "\n" + Costumer +  "Har den: " + Date.ToString("dd:MM:yy kl HH:mm:ss") + " Bestilt følgende: "
                + "\n" + piz + "I alt at betale:".PadRight(82) + totalprice + "Kr.";
            
        }

    }

}
