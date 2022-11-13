using System;
using System.Collections.Generic;
using System.Text;

namespace CarAutoStarter.Models
{
    public class Users
    {
        private List<User> ListOfUsers;

        public void AddUser(User NewUser)
        {
            ListOfUsers.Add(NewUser);
        }
    }
}
