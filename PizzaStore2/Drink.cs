using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class Drink : Product
    {
        public Drink(string Id, string Name, double Price) : base(Id, Name, Price)
        {
        }

        public override string ToString()
        {
            return  Id.PadRight(10) + Name.PadRight(72) + Price + "Kr." + Environment.NewLine;
        }
    }
}
