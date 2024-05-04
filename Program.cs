
#region Example1 





//-----SampleA--------------------------


/////We need to create Instance from Classes and we must to repeat this Circle...

//ICar car = new Benz();
//car.Build();


//ICar car2 = new Ford();
//car.Build();


//ICar car3;

//string type = "B";


//if (type == "B")
//{

//    car3 = new Benz();
//    car3.Build();

//}
//else if (type == "F")
//{

//    car3 = new Ford();
//    car3.Build();

//}

////FunctionA();


//void FunctionA(string type="F")
//{
//    ICar car;




//    if (type == "B")
//    {

//        car = new Benz();
//        car.Build();

//    }
//    else if (type == "F")
//    {

//        car = new Ford();
//        car.Build();

//    }

//}



//-----SampleB--------------------------


////////////////////////// If we have Use from Factory Design Pattern we call CarFactory and get Instance , it`s easy :) 
///                                             Dry ->>>>>>> do not repeat you


//ICar car = CarFactory.GetCar(CarModel.Benz);

//car.Build();








#endregion






Console.ReadLine();
