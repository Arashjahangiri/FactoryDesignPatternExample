using FactoryDesignPatternExample.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternExample.Example1.Entities
{
    public class Ford : ICar
    {
        public void Build()
        {
            Console.WriteLine("Ford Build.....");
        }
    }
}
