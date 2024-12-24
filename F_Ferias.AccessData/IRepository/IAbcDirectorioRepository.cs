using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.IRepository
{
    public interface IAbcDirectorioRepository : IRepository<abc_directorio> { 
        IEnumerable<abc_directorio> GetAllUnidadesResponsables(int Id);
    }
}