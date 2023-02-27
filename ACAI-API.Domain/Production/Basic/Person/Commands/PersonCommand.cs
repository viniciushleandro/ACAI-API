﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACAI_API.Domain.Production.Basic.Person.Commands
{
    public class PersonCommand : BaseCommand
    {
        public string? Name { get; set; }

        public string? Gender { get; set; }

        public string? Phone { get; set; }

        public string? CPFourCNPJ { get; set; }

        public string? RGourRegistrationState { get; set; }

        public string? Address { get; set; }

        public string? Complement { get; set; }

        public string? Number { get; set; }

        public string? Cep { get; set; }

        public string? FantasyName { get; set; }

        public Boolean? Situation { get; set; }

        public string? City { get; set; }

        public DateTime? BirthDate { get; set; }


    }
}
