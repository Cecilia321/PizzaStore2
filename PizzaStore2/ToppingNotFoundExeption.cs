using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class ToppingNotFoundExeption : Exception
    {
        public ToppingNotFoundExeption() : base("Topping not found")
        {

        }

        public ToppingNotFoundExeption(string message) : base(message)
        {

        }
    }
}
