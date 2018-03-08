using Domain.Contexts.DocumentManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            DocumentManagementDB db = new DocumentManagementDB();
            var a = db.NotaryCompanies.FirstOrDefault(x=>x.Id==1);

            Console.ReadKey();
        }
    }
}
