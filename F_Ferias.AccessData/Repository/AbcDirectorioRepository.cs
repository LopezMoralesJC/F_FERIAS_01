using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.Repository
{
    public class AbcDirectorioRepository : Repository<abc_directorio>, IAbcDirectorioRepository {

        private readonly ApplicationDbContext _context;
        public AbcDirectorioRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<abc_directorio> GetAllUnidadesResponsables(int Id)
        {
            //  return _context.abc_Directorio.Where(a => a.id_entidad == Id);
            //  return _context.Set<cp_cepomex_mexico>().Where(e => e.id_entidad == IdEntidad).GroupBy(g => new{g.D_mnpio}).Select(g => g.FirstOrDefault());
                   return _context.Set<abc_directorio>().Where(e => e.id_entidad == Id).GroupBy(g => new{g.nom_oficina}).Select(g => g.FirstOrDefault());
        }
    }
}