using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.Repository;
public class FeriaNacionalRepository : Repository<ferias_nacional>, IFeriaNacionalRepository {
    private readonly ApplicationDbContext _context;
    public FeriaNacionalRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
