using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.IRepository;
    public interface IFeriaNacionalRepository : IRepository<ferias_nacional>
    {
          IQueryable<ferias_nacional> GetAllAsync__2();
    }
