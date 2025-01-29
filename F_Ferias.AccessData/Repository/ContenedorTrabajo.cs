using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using F_Ferias.Models.Models;

namespace F_Ferias.AccessData.Repository;
  public class ContenedorTrabajo : IContenedorTrabajo {

        #region Properties
        #endregion

        #region Readonlys
        private readonly ApplicationDbContext _context;
        #endregion




        public ContenedorTrabajo(ApplicationDbContext context) {
            _context = context;
            // cat_destinatario = new Cat_DestinatariosRepository(_context); 
            c_FUNCIONARIOS_PORTALEMPLEO_Repository = new C_FUNCIONARIOS_PORTALEMPLEO_Repository(_context);
            entidadesRepository = new EntidadesRepository(_context);
            personaRepository = new PersonaRepository(_context);
            feriaNacionalRepository = new FeriaNacionalRepository(_context);
            ferias_Nacionales_BannerRepository = new Ferias_nacionales_bannerRepository(_context);
            abcDirectorioRepository = new AbcDirectorioRepository(_context);
            cpCepomexRepository  = new CpCepomexRepository(_context);
            usersRepository = new UsersRepository(_context);
            feriaLocalRepository = new FeriaLocalRepository(_context);
            ferias_locales_bannerRespository = new Ferias_locales_bannerRespository(_context);
            feriaInversionRepository = new FeriaInversionRepository(_context);
        }








        #region import
        public IC_FUNCIONARIOS_PORTALEMPLEO_Repository c_FUNCIONARIOS_PORTALEMPLEO_Repository  { get; private set; }

        public IEntidadesRepository entidadesRepository  { get; private set; }

        public IPersonaRepository personaRepository { get; private set; }

        public IFeriaNacionalRepository feriaNacionalRepository  { get; private set; }

        public IFerias_nacionales_bannerRepository ferias_Nacionales_BannerRepository { get; private set; }

        public IAbcDirectorioRepository abcDirectorioRepository { get; private set; }

        public ICpCepomexRepository cpCepomexRepository  { get; private set; }

        public IUsersRepository usersRepository   { get; private set; }

        public IFeriaLocalRepository feriaLocalRepository  { get; private set; }

        public IFerias_locales_bannerRespository ferias_locales_bannerRespository  { get; private set; }

        public IFeriaInversionRepository feriaInversionRepository  { get; private set; }

    #endregion









    #region Methods

    public async Task CompleteAsync() {
        
        await _context.SaveChangesAsync();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        #endregion

        private bool _disposed;



    public async ValueTask DisposeAsync()
        {
            await DisposeAsync(true);
            GC.SuppressFinalize(this);
        }
        protected virtual async ValueTask DisposeAsync(bool disposing) {
            if (!_disposed) {
                if (disposing) {
                    // Dispose managed resources.
                    await _context.DisposeAsync();
                }
                _disposed = true;
            }
        }
    }