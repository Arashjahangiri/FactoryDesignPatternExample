using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternExample.Example2.Entity
{
    public class User
    {




        public int UserID { get; set; }
        public string UserFullName { get; set; }


        /// <summary>
        /// Suppose After a time we need to increase this Property and Constractor need to get data
        /// </summary>
        public int UserAge { get; set; }





        //public User(int id, string name)
        //{
        //    UserID = id;
        //    UserFullName = name;

        //}


        public User(int id, string name, int age)
        {
            UserID = id;
            UserFullName = name;

        }



        public void PrintInfo()
        {

            Console.WriteLine($"UserID is : {UserID}\nFullName is {UserFullName}");
        }




    }
}
