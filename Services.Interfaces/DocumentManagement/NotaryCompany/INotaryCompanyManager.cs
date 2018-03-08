using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Interfaces.BaseServices;
using Services.Interfaces.DocumentManagement.NotaryCompany.Request;
using Services.Interfaces.DocumentManagement.NotaryCompany.Response;

namespace Services.Interfaces.DocumentManagement.NotaryCompany
{
    public interface INotaryCompanyManager: IGeneralCRUD<NewNotaryCompany,UpdateNotaryCompany, RegisterdNotaryCompany>
    {
    }
}
