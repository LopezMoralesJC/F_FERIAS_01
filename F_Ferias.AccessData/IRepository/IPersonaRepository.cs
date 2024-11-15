using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.IRepository ;
    public interface IPersonaRepository : IRepository<Persona> {

        Persona Get_Persona(int id);

        Persona Get_Persona(string id);
        
    }