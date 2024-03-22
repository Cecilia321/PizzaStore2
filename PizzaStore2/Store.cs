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
           
            //her ses menuen
            MenuCatalog menuFunctions = new MenuCatalog();
            Console.WriteLine(menuFunctions.PrintMenu());

            //Opretter en Pizza 
            menuFunctions.CreatePizza("Nr. 4", "Annanas", "skinke, ost og annanas", 67);
            Console.WriteLine(menuFunctions.PrintMenu());

            //sletter en pizza
            menuFunctions.DeletePizza("Big Mamma");
            Console.WriteLine(menuFunctions.PrintMenu());

            //opdater en pizza
            menuFunctions.UpdatePizza("Nr. 1", "Margeritha", "Tomat og ost og løg", 85); 
            Console.WriteLine(menuFunctions.PrintMenu());

            //søg efter pizza 
            try
            {
                Pizza p = menuFunctions.SearchPizza("Margeritha");
                Console.WriteLine(p.ToString());
            }
            catch (PizzaNotFoundExeption ex)
            {
                Console.WriteLine(ex.Message);
            }


            CostumerAdministration costumerlist = new CostumerAdministration();
            //her oprettes 2 kunder
            costumerlist.CreateCostumer("bente", 38492086);
            costumerlist.CreateCostumer("Bo", 28574839);
            Console.WriteLine(costumerlist.PrintCostumer());

            //her slettes en kunde
            costumerlist.DeleteCostumer("Bo");
            Console.WriteLine(costumerlist.PrintCostumer());

            //her opdateres kunden
            costumerlist.UpdateCostumer("bente", 39059382);
            Console.WriteLine(costumerlist.PrintCostumer());

            //her søges efter en kunde 
            try
            {
                Costumer c = costumerlist.SearchCostumer("bente");
                Console.WriteLine(c.ToString());
            }
            catch (CostumerNotFoundExeption ex) 
            {
                Console.WriteLine(ex.Message);
            }

           // Order o = new Order(menuFunctions);
            //o.AddPizzaToOrder(menuFunctions.SearchPizza("Margeritha"));
            //Console.WriteLine(o.PrintOrder());

            OrderAdministration orderlist = new OrderAdministration();
            orderlist.CreateOrder(costumerlist.Costumerlist[0], menuFunctions.Pizzalist[0], 0);
            Console.WriteLine(orderlist.PrintOrder());
        }
        
        
       
    }
}
