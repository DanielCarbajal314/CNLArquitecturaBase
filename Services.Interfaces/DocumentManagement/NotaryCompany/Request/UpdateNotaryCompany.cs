using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.DocumentManagement.NotaryCompany.Request
{
    public class UpdateNotaryCompany
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string District { get; set; }
        public string Province { get; set; }
    }
}
