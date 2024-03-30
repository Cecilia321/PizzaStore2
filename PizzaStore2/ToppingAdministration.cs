using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class ToppingAdministration
    {
        private List<Topping> toppinglist = new List<Topping>();

        internal List<Topping> Toppinglist { get => this.toppinglist; set => this.toppinglist = value; }

        public string PrintTopping()
        {
            string cl = "";
            foreach (Topping topping in toppinglist)
            {
                cl = cl + topping.ToString();
            }
            return cl;

        }

        public void CreateTopping(string Id, string Name, double Price)
        {
            Topping t = new Topping(Id, Name, Price);
            toppinglist.Add(t);
        }

        public Topping SearchTopping(string searchWord)
        {
            bool found = false;
            int index = 0;
            Topping foundTopping = null;
            while (found == false && index <= toppinglist.Count - 1)
            {
                if (toppinglist[index].Name.Equals(searchWord))
                {
                    found = true;
                    foundTopping = toppinglist[index];
                }
                index++;
            }
            if (found == false) throw new ToppingNotFoundExeption();
            return foundTopping;

        }

        public void DeleteTopping(string searchWord)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= toppinglist.Count - 1)
            {
                if (toppinglist[index].Name.Equals(searchWord))
                {
                    found = true;
                    toppinglist.RemoveAt(index);
                }
                index++;
            }
            if (found == false) throw new ToppingNotFoundExeption();
        }

        public void UpdateTopping(string Id, string Name, double Price)
        {
            bool found = false;
            int index = 0;
            while ((found == false) && index <= toppinglist.Count - 1)
            {
                if (toppinglist[index].Name.Equals(Name))
                {
                    found = true;
                    toppinglist[index].Id = Id;
                    toppinglist[index].Name = Name;
                    toppinglist[index].Price = Price;
                }
                index++;
            }
            if (found == false) throw new ToppingNotFoundExeption();
        }
    }
}
