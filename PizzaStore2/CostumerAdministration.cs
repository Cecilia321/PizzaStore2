using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class CostumerAdministration
    {

        private List<Costumer> costumerlist = new List<Costumer>();
        

    internal List<Costumer> Costumerlist { get => costumerlist; set => costumerlist = value; }

   

        public string PrintCostumer()
        {
            string cl = "";
            foreach (Costumer costumer in costumerlist) 
            {
                cl = cl + costumer.ToString();
            }
            return cl;
           
        }

        public void CreateCostumer(string name, int number)
        {
            Costumer c = new Costumer(name, number);
            costumerlist.Add(c);
        }

        public Costumer SearchCostumer(string searchWord)
        {
            bool found = false;
            int index = 0;
            Costumer foundCostumer = null;
            while (found == false && index <= costumerlist.Count -1)
            {
                if (costumerlist[index].Name.Equals(searchWord))
                {
                    found = true;
                    foundCostumer = costumerlist[index];
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
            if (found == false) throw new CostumerNotFoundExeption();

        }
            
        
        

      
    }
}
