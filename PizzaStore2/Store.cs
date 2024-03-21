using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class Store
    {
        public void Start()
        {
           

            MenuCatalog menuFunctions = new MenuCatalog();
            Console.WriteLine(menuFunctions.PrintMenu());

            
            

            CostumerAdministration costumerlist = new CostumerAdministration();
            costumerlist.CreateCostumer("bente", 38492086);
            costumerlist.CreateCostumer("Bo", 28574839);
            Console.WriteLine(costumerlist.PrintCostumer());
            costumerlist.DeleteCostumer("Bo");
            Console.WriteLine(costumerlist.PrintCostumer());
            costumerlist.UpdateCostumer("bente", 39059382);
            Console.WriteLine(costumerlist.PrintCostumer());


            try
            {
                Costumer c = costumerlist.SearchCostumer("bente");
                Console.WriteLine(c.ToString());
            }
            catch (CostumerNotFoundExeption ex) 
            {
                Console.WriteLine(ex.Message);
            }

        }
        
        
       
    }
}
