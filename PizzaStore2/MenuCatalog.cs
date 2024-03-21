using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    
    internal class MenuCatalog
    {
        private List<Pizza> pizzalist;
        private List<Drink> drinklist;
        private List<Topping> toppinglist;


        internal List<Pizza> Pizzalist { get => pizzalist; set => pizzalist = value; }
        internal List<Drink> Drinklist { get => drinklist; set => drinklist = value; }
        internal List<Topping> Toppinglist { get => toppinglist; set => toppinglist = value; }


        public MenuCatalog()
        {
            Pizzalist = new List<Pizza>()
        {
            new Pizza("Nr. 1", "Margeritha", "Tomat og ost", 69),
            new Pizza("Nr. 2", "Big Mamma", "Tomat, gorgonzola, reje, asparges og parma skinke", 90),
            new Pizza("Nr. 3", "Italiana", "Tomat, ost, løg og kødsovs", 75),
        };

            Drinklist = new List<Drink>()
        {
            new Drink("Nr. 1", "Cola", 30),
            new Drink("Nr. 2", "Sprite", 22.50),
            new Drink("Nr. 3", "Fanta", 25),
        };

            Toppinglist = new List<Topping>()
        {
            new Topping("Nr. 1", "Ekstra ost", 10),
            new Topping("Nr. 2", "Parma skinke", 14),
            new Topping("Nr. 3", "Løg", 5)
        };
        }


        public string PrintMenu()
        {
            string menu = "";

            foreach (Pizza pizza in Pizzalist)
            {
                menu += pizza.ToString();
                
            }

            foreach (Drink drink in Drinklist)
            {
                menu += drink.ToString();
            }

            foreach(Topping topping in Toppinglist) 
            {
                menu += topping.ToString();

            }

            return menu;
        }
            
    }
        
}

