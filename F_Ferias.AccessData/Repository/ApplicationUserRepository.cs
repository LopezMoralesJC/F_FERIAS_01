using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;
using F_Ferias.AccessData.Repository;
using F_Ferias.Models.Models;
using F_Ferias.AccessData.IRepository;

namespace F_Ferias.AccessData.Repository;
    public class ApplicationUserRepository : Repository<ApplicationUser> , IApplicationUserRepository
    {
                private readonly ApplicationDbContext _context;
        public ApplicationUserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

    }
