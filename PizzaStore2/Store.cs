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
            Console.WriteLine("Welkommen til Big Mammas Pizzaria, her er menuen");
            MenuCatalog menuFunctions = new MenuCatalog();
            Console.WriteLine(menuFunctions.PrintMenu());
            Console.ReadKey();
            Console.Clear();

            //Opretter en Pizza, sletter en pizza og opdatere en pizza. 
            Console.WriteLine("Big Mamma Har fået ny menu, med nye lækre pizzaer: ");
            menuFunctions.CreatePizza("Nr. 4", "Annanas", "skinke, ost og annanas", 67);
            menuFunctions.CreatePizza("Nr. 5", "Svampe", "Tomat, Ost, Skinke og Champingon", 75);
            menuFunctions.CreatePizza("Nr. 6", "Kartoffel", "Kartoffel, ost, bacon, pesto og basilikum", 70);
   
            //slet
            menuFunctions.DeletePizza("Big Mamma");

            //opdater
            menuFunctions.UpdatePizza("Nr. 1", "Margeritha", "Tomat og ost og løg", 85); 
            Console.WriteLine(menuFunctions.PrintMenu());
            Console.ReadKey();
            Console.Clear();

            //søg efter pizza 
            Console.WriteLine("Søg efter pizzaer på menukortet");
            try
            {
                Pizza p = menuFunctions.SearchPizza("Margeritha");
                Console.WriteLine(p.ToString());
            }
            catch (PizzaNotFoundExeption ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Disse kunder er blevet oprette i vores system: ");
            CostumerAdministration costumerlist = new CostumerAdministration();
            //her oprettes 2 kunder
            costumerlist.CreateCostumer("bente", 38492086);
            costumerlist.CreateCostumer("Bo", 28574839);
            costumerlist.CreateCostumer("Ellen", 37849203);
            costumerlist.CreateCostumer("Marcus", 39480693);
            Console.WriteLine(costumerlist.PrintCostumer());
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Kundelisten er blevet opdateret.");
            //slet en kunde
            costumerlist.DeleteCostumer("Bo");

            //opdater en kunden
            costumerlist.UpdateCostumer("bente", 39059382);
            Console.WriteLine(costumerlist.PrintCostumer());
            Console.ReadKey();
            Console.Clear();

            //her søges efter en kunde 
            Console.WriteLine("Søg efter en kunde: ");
            try
            {
                Costumer c = costumerlist.SearchCostumer("bente");
                Console.WriteLine(c.ToString());
            }
            catch (CostumerNotFoundExeption ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            Console.Clear();

           
            OrderAdministration order1 = new OrderAdministration();
            List<Pizza> p1 = new List<Pizza>();
            p1.Add(menuFunctions.Pizzalist[1]);

            List<Topping> t1 = new List<Topping>();
            t1.Add(menuFunctions.Toppinglist[0]);

            List<Drink> d1 = new List<Drink>();
            d1.Add(menuFunctions.Drinklist[1]);

            order1.CreateOrder(costumerlist.Costumerlist[0], p1, d1, 1, t1);
            Console.WriteLine(order1.PrintOrder());
            Console.ReadKey();
            Console.Clear();

            OrderAdministration order2 = new OrderAdministration();
            List<Pizza> p2 = new List<Pizza>();
            p2.Add(menuFunctions.Pizzalist[3]);
            p2.Add(menuFunctions.Pizzalist[3]);

            List<Topping> t2 = new List<Topping>();
            t2.Add(menuFunctions.Toppinglist[2]);

            List<Drink> d2 = new List<Drink>();
            d2.Add(menuFunctions.Drinklist[2]);
            order2.CreateOrder(costumerlist.Costumerlist[1], p2, d2, 2, t2);
            Console.WriteLine(order2.PrintOrder());
            Console.ReadKey();
            Console.Clear();

            OrderAdministration order3 = new OrderAdministration();
            List<Pizza> p3 = new List<Pizza>();
            p3.Add(menuFunctions.Pizzalist[3]);
            p3.Add(menuFunctions.Pizzalist[4]);
            p3.Add(menuFunctions.Pizzalist[0]);

            List<Topping> t3 = new List<Topping>();
            t3.Add(menuFunctions.Toppinglist[2]);

            List<Drink> d3 = new List<Drink>();
            d3.Add(menuFunctions.Drinklist[2]);
            d3.Add(menuFunctions.Drinklist[0]);

            order3.CreateOrder(costumerlist.Costumerlist[2], p3, d3, 3, t3);
            Console.WriteLine(order3.PrintOrder());
            Console.ReadKey();
            Console.Clear();

            //Slet ordre 1
            order1.DeleteOrder(1);
            Console.WriteLine(order1.PrintOrder());
            Console.WriteLine(order2.PrintOrder());
            Console.WriteLine("\n" + order3.PrintOrder());
        }
        
        
       
    }
}
