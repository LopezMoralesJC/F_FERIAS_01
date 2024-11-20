using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.Repository
{
    public class C_FUNCIONARIOS_PORTALEMPLEO_Repository : Repository<C_FUNCIONARIOS_PORTALEMPLEO>, IC_FUNCIONARIOS_PORTALEMPLEO_Repository
    {
         private readonly ApplicationDbContext _context;
        public C_FUNCIONARIOS_PORTALEMPLEO_Repository(ApplicationDbContext context) : base(context) 
        {
             _context = context; 
        }

        public C_FUNCIONARIOS_PORTALEMPLEO Get_FUNCIONARIOS_PORTALEMPLEO(string email)
        {
           return _context.C_FUNCIONARIOS_PORTALEMPLEO.Where(a => a.EMAIL == email).FirstOrDefault();
        }

        public C_FUNCIONARIOS_PORTALEMPLEO Get_FUNCIONARIOS_PORTALEMPLEO(int id)
        {
            return _context.C_FUNCIONARIOS_PORTALEMPLEO.Where(a=> a.id_usuario == id).FirstOrDefault();
        }

        public IEnumerable<C_FUNCIONARIOS_PORTALEMPLEO> Get_FUNCIONARIOS_PORTALEMPLEOS()
        {
            return _context.C_FUNCIONARIOS_PORTALEMPLEO.ToList();
        }
    }
}