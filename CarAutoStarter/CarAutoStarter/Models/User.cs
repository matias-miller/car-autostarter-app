﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarAutoStarter.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public string[] CarsOwned { get; set; }

    }
}
