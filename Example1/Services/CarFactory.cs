
using FactoryDesignPatternExample.Example1.Entities;
using FactoryDesignPatternExample.Example1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternExample.Example1.Interface
{
    public class CarFactory
    {
        public static ICar GetCar(CarModel model)
        {
            ICar _instance = null;
            switch (model)
            {
                case CarModel.Benz :
                    _instance = new Benz();
                    break;
                case CarModel.Ford:
                    _instance = new Ford();
                    break;
                case  CarModel.Honda:
                    _instance = new Honda();
                    break;

            }

            return _instance;
        }


    }////////////End of class

}
