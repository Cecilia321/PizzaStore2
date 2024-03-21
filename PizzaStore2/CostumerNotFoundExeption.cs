using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore2
{
    public class CostumerNotFoundExeption : Exception
    {
        public CostumerNotFoundExeption() : base("Costumer not found")
        {

        }

        public CostumerNotFoundExeption(string message) : base(message)
        {

        }
    }
}
