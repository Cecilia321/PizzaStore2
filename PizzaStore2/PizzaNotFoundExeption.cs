using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    internal class PizzaNotFoundExeption : Exception
    {
        public PizzaNotFoundExeption() : base("Pizza not found")
        {

        }

        public PizzaNotFoundExeption(string message) : base(message)
        {

        }
    }
}
