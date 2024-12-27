using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.Repository
{
    public class CpCepomexRepository : Repository<cp_cepomex_mexico> , ICpCepomexRepository
    {
        private readonly ApplicationDbContext _context;
        public CpCepomexRepository(ApplicationDbContext context) : base(context) {
             _context = context; 
        }

        public IEnumerable<cp_cepomex_mexico> get__all__vialidades()
        {
           return  _context.Set<cp_cepomex_mexico>().GroupBy(e => new{e.c_tipo_asenta}).Select(g => g.FirstOrDefault());
        }
    }
}