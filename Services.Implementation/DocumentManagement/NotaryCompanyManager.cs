using Services.Interfaces.DocumentManagement.NotaryCompany;
using Services.Interfaces.DocumentManagement.NotaryCompany.Request;
using Services.Interfaces.DocumentManagement.NotaryCompany.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Contexts.DocumentManagement;
using AutoMapper;
using Domain.Entities.DocumentManagement;

namespace Services.Implementation.DocumentManagement
{
    public class NotaryCompanyManager : INotaryCompanyManager
    {
        
        public RegisterdNotaryCompany Create(NewNotaryCompany creationRequest)
        {
            using (DocumentManagementDB db = new DocumentManagementDB())
            {
                NotaryCompany newNotary = Mapper.Map<NotaryCompany>(creationRequest);
                db.NotaryCompanies.Add(newNotary);
                db.SaveChanges();
                return Mapper.Map<RegisterdNotaryCompany>(newNotary);
            }
        }

        public void Delete(int registerId)
        {
            using (DocumentManagementDB db = new DocumentManagementDB())
            {
                NotaryCompany newNotary = new NotaryCompany() { Id = registerId, Deleted = true };
                db.NotaryCompanies.Attach(newNotary);
                db.Entry(newNotary).Property(x => x.Deleted).IsModified = true;
                db.SaveChanges();
            }
        }

        public List<RegisterdNotaryCompany> List()
        {
            using (DocumentManagementDB db = new DocumentManagementDB())
            {
                return db.NotaryCompanies.Where(x => x.Deleted == false)
                                         .ToList()
                                         .Select(x => Mapper.Map<RegisterdNotaryCompany>(x))
                                         .ToList();
            }
        }

        public RegisterdNotaryCompany Update(UpdateNotaryCompany registroParaActualizar)
        {
            using (DocumentManagementDB db = new DocumentManagementDB())
            {
                NotaryCompany notaryToUpdate = Mapper.Map<NotaryCompany>(registroParaActualizar);
                db.NotaryCompanies.Attach(notaryToUpdate);
                db.Entry(notaryToUpdate).Property(x => x.Email).IsModified = true;
                db.Entry(notaryToUpdate).Property(x => x.Address).IsModified = true;
                db.Entry(notaryToUpdate).Property(x => x.Phone).IsModified = true;
                db.Entry(notaryToUpdate).Property(x => x.Department).IsModified = true;
                db.Entry(notaryToUpdate).Property(x => x.District).IsModified = true;
                db.Entry(notaryToUpdate).Property(x => x.Province).IsModified = true;
                db.SaveChanges();
                return Mapper.Map<RegisterdNotaryCompany>(notaryToUpdate);
            }
        }
    }
}
