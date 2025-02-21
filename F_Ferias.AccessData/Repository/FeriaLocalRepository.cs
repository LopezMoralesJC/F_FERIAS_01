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

    public void UpdateFeriaLocal(ferias_empleo_local feria)
    {
            // var objFromDb = _context.Ferias_Empleo_Local.FirstOrDefault(c => c.id == feria.id);
            // Console.WriteLine(objFromDb);
            //     objFromDb = feria;
            //     _context.SaveChanges();



        var dbBook = _context.Ferias_Empleo_Local.Find(feria.id);


        _context.Entry(dbBook).CurrentValues.SetValues(feria);

        _context.SaveChanges();
    }
}
   