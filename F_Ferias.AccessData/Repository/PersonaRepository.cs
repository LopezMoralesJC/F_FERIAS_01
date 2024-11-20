using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.Repository;
    public class PersonaRepository : Repository<Persona> , IPersonaRepository {
        
        private readonly ApplicationDbContext _context;
        public PersonaRepository(ApplicationDbContext context) : base(context) 
        {
             _context = context; 
        }

        public Persona Get_Persona(int id)
        {
          return _context.Persona.Where(a => a.id_usuario == id).FirstOrDefault();
        }

    public Persona Get_Persona(string id)
    {
          return _context.Persona.Where(a => a.correo_electronico == id).FirstOrDefault();
    }
}
