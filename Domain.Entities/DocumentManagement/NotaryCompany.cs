using Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.DocumentManagement
{
    public class NotaryCompany:BaseGeneralEntity
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
        public ICollection<Employee> Employees { get; set; }
    }
}
