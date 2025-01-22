using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;

namespace F_Ferias.AccessData.Repository;
    public class UsersRepository : Repository<ApplicationUser> , IUsersRepository
    {
        private readonly ApplicationDbContext _context;
        public UsersRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context; 
        }
       

        public IEnumerable<ApplicationUser> Get_entidades()
        {
            return _context.Users.Where(a => a.estatus == 1).OrderBy(a =>a.Id).ToList();
        }
    
    
        
    }
