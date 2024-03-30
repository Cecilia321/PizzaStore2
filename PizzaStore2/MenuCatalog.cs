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
    

        public List<Pizza> Pizzalist { get => pizzalist; set => pizzalist = value; }
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
            new Drink("Nr. 1", "Cola", 30.50),
            new Drink("Nr. 2", "Sprite", 30.50),
            new Drink("Nr. 3", "Fanta", 30.50),
            new Drink("Nr. 4", "Pepsi", 29)
        };

            Toppinglist = new List<Topping>()
        {
            new Topping("Nr. 1", "Ekstra ost", 10),
            new Topping("Nr. 2", "Tilføj Parma skinke", 14),
            new Topping("Nr. 3", "Ekstra Løg", 5)
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

        public void CreatePizza(string id, string Name, string Topping, double Price)
        {
            Pizza p = new Pizza(id, Name, Topping, Price);
            pizzalist.Add(p);
        }

        public void AddTopping(string Id, string Name, double Price)
        {
            Topping t = new Topping(Id, Name, Price);
            toppinglist.Add(t);
        }


        public Pizza SearchPizza(string searchWord)
        {
            bool found = false;
            int index = 0;
            Pizza foundPizza = null;
            while (found == false && index <= pizzalist.Count - 1)
            {
                if (pizzalist[index].Name.Equals(searchWord))
                {
                    found = true;
                    foundPizza = pizzalist[index];
                }
                index++;
            }
            if (found == false) throw new PizzaNotFoundExeption();
            return foundPizza;

        }

        public void DeletePizza(string searchword)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= pizzalist.Count - 1)
            {
                if (pizzalist[index].Name.Equals(searchword))
                {
                    found = true;
                    pizzalist.RemoveAt(index);
                    
                }
                index++;
            }
            if (found == false) throw new PizzaNotFoundExeption();
        }

        public void UpdatePizza(string id, string Name, string Topping, double Price)
        {
            bool found = false;
            int index = 0;
            while ((found == false) && index <= pizzalist.Count - 1)
            {
                if (pizzalist[index].Name.Equals(Name))
                {
                    found = true;
                    pizzalist[index].Name = Name;
                    pizzalist[index].Topping = Topping;
                    pizzalist[index].Price = Price;
                }
                index++;
            }
            if (found == false) throw new PizzaNotFoundExeption();

        }

    }
        
}

