using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.Models.Models;
using F_Ferias.Utilities;
using F_Ferias.Utilities.Datos;
using Humanizer;
using Microsoft.EntityFrameworkCore;


namespace F_Ferias.AccessData.Repository;
    public class CpCepomexRepository : Repository<cp_cepomex_mexico> , ICpCepomexRepository
    {
        private readonly ApplicationDbContext _context;
        public CpCepomexRepository(ApplicationDbContext context) : base(context) {
             _context = context; 
        }

        public IEnumerable<cp_cepomex_mexico> get__all__colonias(int IdEntidad, int IdMunicipio)
        {
             return _context.cp_Cepomex_Mexico.Where(g => g.id_entidad == IdEntidad && g.c_mnpio == IdMunicipio);
        }

        public IEnumerable<cp_cepomex_mexico> get__all__municipios(int IdEntidad)
        {
           return _context.Set<cp_cepomex_mexico>().Where(g => g.id_entidad == IdEntidad).OrderBy(g => g.D_mnpio).GroupBy(g => new{g.D_mnpio}).Select(g => g.FirstOrDefault());
           // .GroupBy(g => new{g.D_mnpio}).Select(g => g.FirstOrDefault());
        }

        public IEnumerable<cp_cepomex_mexico> get__all__vialidades()
        {
           return _context.Set<cp_cepomex_mexico>().GroupBy(e => new{e.c_tipo_asenta}).Select(g => g.FirstOrDefault());
        }

        public IEnumerable<cp_cepomex_mexico> get__cp__entidades(string cp)
        {
           return _context.Set<cp_cepomex_mexico>().Where(g => g.d_codigo == cp).GroupBy(g => new{g.id_entidad}).Select(g => g.FirstOrDefault());
  
        }

        public IEnumerable<cp_cepomex_mexico> get__all__colonias_cp(string cp)
        {
           return _context.cp_Cepomex_Mexico.Where(c => c.d_codigo == cp);
        }

        public IEnumerable<cp_cepomex_mexico> get__colonias__cp(string cp, string colonia)
        {
           
            // return _context.cp_Cepomex_Mexico.Where(c =>c.d_codigo == cp && c.d_asenta == colonia );
            return _context.cp_Cepomex_Mexico.Where(c =>c.d_codigo == cp &&  EF.Functions.Unaccent(c.d_asenta.ToLower()) == colonia.ToLower());
            //.Where(x => people.ILike(EF.Functions.Unaccent(x.Name)....
          // var entity =  _context.cp_Cepomex_Mexico.FromSqlRaw("", "");
        }

    public cp_cepomex_mexico get_vialidad_unique(int Id_Vialidad)
    {
         return _context.cp_Cepomex_Mexico.Where(g => g.c_tipo_asenta == Id_Vialidad).FirstOrDefault();
    }
}
