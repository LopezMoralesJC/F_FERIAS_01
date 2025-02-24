using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
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

    public IEnumerable<ferias_nacional> GetListaFeriasNacionales()
    {
       return _context.Ferias_Nacional.Where(f => f.estatus == 1);
    }

    public void UpdateFeriaNacional(ferias_nacional feria)
    {
            //  var objFromDb = _context.Ferias_Nacional.FirstOrDefault(c => c.id == ferias_Nacional.id);
            //     objFromDb = ferias_Nacional;
            //     _context.SaveChanges();


        var feria_ant = _context.Ferias_Nacional.Find(feria.id);
        _context.Entry(feria_ant).CurrentValues.SetValues(feria);
        _context.SaveChanges();
    }

    IQueryable<ferias_nacional> IFeriaNacionalRepository.GetAllAsync__2() {
         var employees = _context.Ferias_Nacional
            .Select(e => new ferias_nacional { 
                id = e.id,
                nombre = e.nombre,

                fecha_inicio = e.fecha_inicio,
                fecha_fin = e.fecha_fin,
                hora_inicio = e.hora_inicio,
                hora_fin = e.hora_fin,

                estatus = e.estatus,
                entidades_todas = e.entidades_todas,
                // Dataentidades_selection = e.Dataentidades_selection,
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


//cp_cepomex_mexico data_geo_go = JsonConvert.DeserializeObject<cp_cepomex_mexico>(responseContent_Geo);