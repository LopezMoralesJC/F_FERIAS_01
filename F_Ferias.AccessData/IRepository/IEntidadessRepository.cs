using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.IRepository
{
    public interface IEntidadesRepository : IRepository<entidad> {
         entidad Get_entidad(int id_entidad);

    
        IEnumerable<entidad> Get_entidades();

        IEnumerable<entidad> Get_entidades_filter(int id_entidad);
    }
}