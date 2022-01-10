﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaRestaurant.Models
{
    public class Client:Account
    {
        public int ClientID { get; set; }
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public string Email  { get; set; }
    }
}
