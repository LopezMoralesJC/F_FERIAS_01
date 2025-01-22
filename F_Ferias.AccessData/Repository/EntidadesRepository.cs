using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.Repository
{
    public class EntidadesRepository : Repository<entidad>, IEntidadesRepository
    {
           private readonly ApplicationDbContext _context;
        public EntidadesRepository(ApplicationDbContext context) : base(context) 
        {
             _context = context; 
        }
        public entidad Get_entidad(int id_entidad)
        {
             return _context.entidades.Where(a => a.Id == id_entidad).FirstOrDefault();
        }

        public IEnumerable<entidad> Get_entidades()
        {
             return _context.entidades.Where(a => a.Estatus == 1).OrderBy(a =>a.Id).ToList();
        }

        public IEnumerable<entidad> Get_entidades_filter(int id_entidad)
        {
              return _context.entidades.Where(a => a.Estatus == 1 && a.Id == id_entidad).OrderBy(a =>a.Id).ToList();
        }
    }
}