using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.IRepository
{
    public interface ICpCepomexRepository : IRepository<cp_cepomex_mexico>
    {
         IEnumerable<cp_cepomex_mexico> get__all__vialidades();

         IEnumerable<cp_cepomex_mexico> get__all__municipios(int IdEntidad);

         IEnumerable<cp_cepomex_mexico> get__all__colonias(int IdEntidad , int IdMunicipio);

        IEnumerable<cp_cepomex_mexico> get__all__colonias_cp(string cp );

         IEnumerable<cp_cepomex_mexico> get__cp__entidades(string cp);


        
    }
}