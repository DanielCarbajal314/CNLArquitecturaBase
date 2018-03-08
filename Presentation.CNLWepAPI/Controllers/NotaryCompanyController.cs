using Services.Interfaces.DocumentManagement.NotaryCompany;
using Services.Interfaces.DocumentManagement.NotaryCompany.Request;
using Services.Interfaces.DocumentManagement.NotaryCompany.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation.CNLWepAPI.Controllers
{
    public class NotaryCompanyController : ApiController
    {
        INotaryCompanyManager _notaryCompanyManager;

        public NotaryCompanyController(INotaryCompanyManager notaryCompanyManager) {
            this._notaryCompanyManager = notaryCompanyManager;
        }

        [HttpPost]
        public RegisterdNotaryCompany Create(NewNotaryCompany creationRequest)
        {
            RegisterdNotaryCompany newRegisterdNotaryCompany = this._notaryCompanyManager.Create(creationRequest);
            return newRegisterdNotaryCompany;
        }

        [HttpDelete]
        public void Delete(int registerId)
        {
            this._notaryCompanyManager.Delete(registerId);
        }

        [HttpGet]
        public List<RegisterdNotaryCompany> List()
        {
            return this._notaryCompanyManager.List();
        }

        [HttpPut]
        public RegisterdNotaryCompany Update(UpdateNotaryCompany registerToUpdate)
        {
            RegisterdNotaryCompany updateRegisteredCompany = this._notaryCompanyManager.Update(registerToUpdate);
            return updateRegisteredCompany;
        }
    }
}
