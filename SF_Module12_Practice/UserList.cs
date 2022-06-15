using System;
using System.Text;
using System.Collections.Generic;

namespace SF_Module12_Practice
{
    public class UserList
    {
        private List<User> users = new List<User>();

        public List<User> GetUsers()
        {
            users.Add(new User() { Login = "IvashkaShadow", Name = "Ivan", IsPremium = false });
            users.Add(new User() { Login = "DrewTheProgrammer", Name = "Andrew", IsPremium = true });
            users.Add(new User() { Login = "MadKate", Name = "Ekaterina", IsPremium = true });
            users.Add(new User() { Login = "MerryMary", Name = "Mary", IsPremium = false });
            users.Add(new User() { Login = "VeNoM", Name = "Max", IsPremium = true });

            return users;
        }
    }
}