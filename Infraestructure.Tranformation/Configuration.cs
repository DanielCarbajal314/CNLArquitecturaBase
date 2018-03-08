using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities.DocumentManagement;
using Services.Interfaces.DocumentManagement.NotaryCompany.Request;
using Services.Interfaces.DocumentManagement.NotaryCompany.Response;

namespace Infraestructure.Tranformation
{
    public class Configuration
    {
        public static void InicializarMapas()
        {
            Mapper.Initialize(configuration => {
                configuration.CreateMap<NewNotaryCompany, NotaryCompany>();
                configuration.CreateMap<NotaryCompany, RegisterdNotaryCompany>();
                configuration.CreateMap<UpdateNotaryCompany, NotaryCompany>();
            });
        }
    }
}
