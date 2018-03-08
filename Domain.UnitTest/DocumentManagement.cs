using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Contexts.DocumentManagement;
using Domain.Entities.DocumentManagement;

namespace Domain.UnitTest
{
    [TestClass]
    public class DocumentManagement
    {

        [AssemblyInitialize]
        static public void TestInitialization(TestContext testContext)
        {
            using (DocumentManagementDB db = new DocumentManagementDB())
            {
                if (db.Database.Exists())
                    db.Database.Delete();
            }
        }

        [TestMethod]
        public void DatabaseCreation()
        {
            using (DocumentManagementDB db = new DocumentManagementDB())
            {
                db.Database.Create();
            }
        }

        [TestMethod]
        public void CreateCompany()
        {
            using (DocumentManagementDB db = new DocumentManagementDB())
            {
                NotaryCompany newNotaryCompany = new NotaryCompany()
                {
                    Address = "Av La Marina 750",
                    Name = "Notaria Inicial",
                    Department = "Callao",
                    Province = "Callao",
                    District = "La Perla",
                    Email = "Daniel.Carbajal@pucp.edu.pe",
                    Phone = "980784506",
                    RUC = "10700078006",
                    SunatsRegistrationDate = DateTime.Now
                };
                db.NotaryCompanies.Add(newNotaryCompany);
                db.SaveChanges();
            }
        }
    }
}
