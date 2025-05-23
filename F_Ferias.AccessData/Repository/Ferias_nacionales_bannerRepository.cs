using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.Repository;
public class Ferias_nacionales_bannerRepository : Repository<ferias_nacionales_banner>, IFerias_nacionales_bannerRepository {
    private readonly ApplicationDbContext _context;
    public Ferias_nacionales_bannerRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}
