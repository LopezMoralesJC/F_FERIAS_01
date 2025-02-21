using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.Repository;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.IRepository
{
    public interface IFeriaLocalRepository : IRepository<ferias_empleo_local> 
    {
            void UpdateFeriaLocal(ferias_empleo_local feria);
    }
}