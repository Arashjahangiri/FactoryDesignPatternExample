using FactoryDesignPatternExample.Example2.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPatternExample.Example2.Services
{


    public class UserFactory
    {
        public static User GetUser()
        {
            User _user = new User(1, "Arash jahangiri", 29);
            return _user;
        }

    }



}
