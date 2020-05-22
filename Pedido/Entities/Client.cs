﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Pedido.Entities
{
    class Client
    {
        public string Name { get; set; }
        public String Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}