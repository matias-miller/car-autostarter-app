using System;
using System.Collections.Generic;
using System.Text;

namespace CarAutoStarter.Models
{
    public class Users
    {
        public List<User> ListOfUsers = new List<User>();

        public void AddUser(User NewUser)
        {
            ListOfUsers.Add(NewUser);
        }

    }
}
