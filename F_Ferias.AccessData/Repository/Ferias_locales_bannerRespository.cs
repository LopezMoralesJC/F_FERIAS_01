using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.Repository
{
    public class Ferias_locales_bannerRespository : Repository<ferias_locales_banners> , IFerias_locales_bannerRespository
    {
         private readonly ApplicationDbContext _context;
    public  Ferias_locales_bannerRespository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
    }
}