using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Identity;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.Data
{
    public interface IAutorizationService
    {
        Task<AutorizationResponce> DevolverToken(Login model);
    }
}