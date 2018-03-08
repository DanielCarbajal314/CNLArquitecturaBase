using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Shared
{
    public class BaseGeneralEntity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Deleted { get; set; }

        public BaseGeneralEntity() {
            this.CreationDate = DateTime.Now;
            this.Deleted = false;
        }

    }
}
