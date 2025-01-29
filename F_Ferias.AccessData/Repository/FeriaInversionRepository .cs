using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.Repository
{
    public class FeriaInversionRepository  : Repository<feria_inversion> , IFeriaInversionRepository
    {
    private readonly ApplicationDbContext _context;
    public  FeriaInversionRepository (ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
    }
}