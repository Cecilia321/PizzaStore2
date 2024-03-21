using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class Pizza : Product
    {
        string topping;

        public Pizza(string Id, string Name, string Topping, double Price) : base(Id, Name, Price)
        {
            topping = Topping;
        }

        public string Topping { get => topping; set => topping = value; }

        public override string ToString()
        {
            return Id.PadRight(10) + Name.PadRight(10) + ": " + topping.PadRight(60) + Price + "kr." + Environment.NewLine;
        }
    }
}
