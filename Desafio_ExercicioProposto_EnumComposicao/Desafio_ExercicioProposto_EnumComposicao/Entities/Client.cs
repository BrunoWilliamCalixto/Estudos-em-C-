﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_ExercicioProposto_EnumComposicao.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime birthDate { get; set; }

        public Client() { }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            this.birthDate = birthDate;
        }
    }
}
