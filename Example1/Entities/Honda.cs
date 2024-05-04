using FactoryDesignPatternExample.Example1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternExample.Example1.Entities
{
    public class Honda : ICar
    {
        public void Build()
        {
            Console.WriteLine("Honda Build.....");
        }
    }
}
