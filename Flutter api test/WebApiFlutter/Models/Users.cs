﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFlutter.Models
{
    public class Users
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public string Token { get; set; }
        public string Direction { get; set; }
        public int Mobile { get; set; }

    }
}
