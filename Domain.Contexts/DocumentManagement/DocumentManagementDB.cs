using Domain.Entities.DocumentManagement;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contexts.DocumentManagement
{
    public class DocumentManagementDB:DbContext
    {
        private static readonly string ConnectionStringName = "DocumentManagementDB";

        public DocumentManagementDB() : base(ConnectionStringName) {


        }

        public DbSet<NotaryCompany> NotaryCompanies { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
