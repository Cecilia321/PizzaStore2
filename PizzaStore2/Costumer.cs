using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore2
{
    internal class Costumer
    {
        string name;
        int number;

        public string Name { get => name; set => name = value; }
        public int Number { get => number; set => number = value; }

        public Costumer(string Name, int Number)
        {
            name = Name;
            number = Number;
           
        }
        
        public override string ToString()
        {
            return "Navn: " + name.PadRight(10) + "Tlf:" + number + "\n" ;
        }
    }
}
