# Design Pattern Factory

Hello Friends, in this Sample we review about Factory Design Pattern...

Description:

This pattern comes under the creational patterns which are widely used in programming constructs. In other words, “This Pattern provides the best way to create the Objects. In Factory patterns we create the object of the Class without Exposing the Creation/Instantiation Logic to the User who wants to create the Object and then return the newly Created object using the Common Interface which is inherited  by the Class”.


In Our Project we use from 2 Example, in Example1 we use from Famous Example Car.
in this project we have one Interface like "ICar"...

    public interface ICar
    {
        public void Build();
    }

and another Class that Implementation this Interface like "Benz , Ford , Honda"


 public class Benz : ICar
 {
     public void Build()
     {
         Console.WriteLine("Benz Build...");
     }
 }//////////////////End of class


 public class Ford : ICar
 {
     public void Build()
     {
         Console.WriteLine("Ford Build....");
     }
 }////////////End of class


 public class Honda : ICar
 {
     public void Build()
     {
         Console.WriteLine("Honda Build....");
     }
 }

Suppose in program.cs we need to create Instance for Icar and call Build Method of class:

//ICar car = new Benz();
//car.Build();


//ICar car2 = new Ford();
//car.Build();

in this method we must to repeat create instance and it`s better we use from CarFactory....

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


  public enum CarModel
  {
      Benz,
      Ford ,
      Honda
  }

////////////////////////// If we have Use from Factory Design Pattern we call CarFactory and get Instance , it`s easy :) 
  

//ICar car = CarFactory.GetCar(CarModel.Benz);
//car.Build();



And in Example2, suppose we have one class like User and we must create instance of this class in entry project.
and one time maybe we need Add one parameter for constractor and in this time we must change any instanse of this class . 
so better we use from Factory Design Pattern . Please Check Project.
Thank you , i hope so useful for you.