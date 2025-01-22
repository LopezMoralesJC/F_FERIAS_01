using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.Models.Identity;

namespace F_Ferias.AccessData.Repository;
    public interface IUsersRepository : IRepository<ApplicationUser> {

        IEnumerable<ApplicationUser> Get_entidades();
    }
    
        






    
