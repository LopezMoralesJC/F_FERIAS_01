using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;

namespace F_Ferias.AccessData.Repository;
  public class ContenedorTrabajo : IContenedorTrabajo
    {

        #region Properties
        #endregion

        #region Readonlys
        private readonly ApplicationDbContext _context;
        #endregion
        public ContenedorTrabajo(ApplicationDbContext context)
        {
            _context = context;
            // cat_destinatario = new Cat_DestinatariosRepository(_context); 
            c_FUNCIONARIOS_PORTALEMPLEO_Repository = new C_FUNCIONARIOS_PORTALEMPLEO_Repository(_context);
        }

        // public ICat_DestinatariosRepository cat_destinatario { get; private set; }


     

        public IC_FUNCIONARIOS_PORTALEMPLEO_Repository c_FUNCIONARIOS_PORTALEMPLEO_Repository  { get; private set; }
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