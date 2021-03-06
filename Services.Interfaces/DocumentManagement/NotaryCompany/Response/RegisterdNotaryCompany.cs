﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.DocumentManagement.NotaryCompany.Response
{
    public class RegisterdNotaryCompany
    {
        public int Id { get; set; }
        public string RUC { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
    }
}
