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

     IQueryable<ferias_nacional> IFeriaNacionalRepository.GetAllAsync__2()
    {
         var employees = _context.Ferias_Nacional
            .Select(e => new ferias_nacional
            { 
                id = e.id,
                nombre = e.nombre,

                fecha_inicio = e.fecha_inicio,
                fecha_fin = e.fecha_fin,
                hora_inicio = e.hora_inicio,
                hora_fin = e.hora_fin,

                estatus = e.estatus,
                entidades_todas = e.entidades_todas,
                Dataentidades_selection = e.Dataentidades_selection,
                file__name = e.file__name,
                feria_logo_banner = e.feria_logo_banner,

                create_at = e.create_at,
                update_at = e.update_at,
                user_create = e.user_create, 
                user_upddel = e.user_upddel
            }).OrderBy(e =>e.id);

        return employees;
    }

}
