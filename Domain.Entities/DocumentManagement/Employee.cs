using Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.DocumentManagement
{
    public class Employee : BaseGeneralEntity
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string User { get; set; }
        public string PassWord { get; set; }
        public bool CanLogin { get; set; }
        public NotaryCompany NotaryCompany { get; set; }

        public Employee()
        {
            this.CanLogin = false;
        }
    }
}
