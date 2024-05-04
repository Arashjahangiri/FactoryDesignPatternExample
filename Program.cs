
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


#region Example2






////Sample A------------------

//User userA1 = new User(1, "Javad");
//userA1.PrintInfo();


//FunctionA();



/*
 * 
 * Suppose we used from this class(User) from another method or pages... 
 * so we mnust to create Instanse from that class like FunctionA
 */


//void FunctionA()
//{
//    User userA2 = new User(1, "Tom");
//    userA2.PrintInfo();
//}


////////Suppose After some time constractor of Class User Added one parameter like "UserAge" we have some error in here so Check SampleB

////Sample B------------------
///

// User user1 = UserFactory.GetUser();
//user1.PrintInfo();

//FunctionB();

//void FunctionB()
//{

//    User user2 = UserFactory.GetUser();
//    user2.PrintInfo();

//}


////// if we help from Factory Design Pattern we just to change UserFactory for Create Instance :)







#endregion




Console.ReadLine();
