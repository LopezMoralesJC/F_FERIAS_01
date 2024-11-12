using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.IRepository;
    public interface IC_FUNCIONARIOS_PORTALEMPLEO_Repository : IRepository<C_FUNCIONARIOS_PORTALEMPLEO>{
        
        C_FUNCIONARIOS_PORTALEMPLEO Get_FUNCIONARIOS_PORTALEMPLEO(string email);

    
        IEnumerable<C_FUNCIONARIOS_PORTALEMPLEO> Get_FUNCIONARIOS_PORTALEMPLEOS();

    }