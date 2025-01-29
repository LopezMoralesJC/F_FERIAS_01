using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.Repository ; 
    public class FeriaLocalRepository : Repository<ferias_empleo_local> , IFeriaLocalRepository
    {
          private readonly ApplicationDbContext _context;
    public FeriaLocalRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }

    
}
