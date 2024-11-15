using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.IRepository;
       public interface IContenedorTrabajo : IAsyncDisposable {


        #region Properties
      
        IC_FUNCIONARIOS_PORTALEMPLEO_Repository c_FUNCIONARIOS_PORTALEMPLEO_Repository {get;}
        IEntidadesRepository entidadesRepository {get;}

        IPersonaRepository personaRepository {get;}

        #endregion


        #region Methods
        void Save();

        Task CompleteAsync();
        #endregion

    }