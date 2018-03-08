using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.DocumentManagement.NotaryCompany.Request
{
    public class NewNotaryCompany
    {
        public string RUC { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime SunatsRegistrationDate { get; set; }
        public string Department { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
    }
}
