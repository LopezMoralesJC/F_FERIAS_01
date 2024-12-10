using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using F_Ferias.AccessData.IRepository;
using Microsoft.EntityFrameworkCore;

namespace F_Ferias.AccessData.Repository;

      public class Repository<T> : IRepository<T> where T : class {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> _DbSet;
        public Repository(ApplicationDbContext context)
        {
            this._context = context;
            this._DbSet = context.Set<T>();   
        }

        public void Add(T entity) {
           _DbSet.Add(entity);
        }

        public T Get(int id) {
            return _DbSet.Find(id);
        }



        public T GetS(string id) {
            return _DbSet.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null) {
            IQueryable<T> query = _DbSet;
            if (filter != null) {
                query = query.Where(filter);
            }
            if (includeProperties != null) {
                foreach (var includepropertie in includeProperties.Split(new char[] { ',' } , StringSplitOptions.RemoveEmptyEntries)) {
                    query = query.Include(includepropertie);
                }
               
            }
            if (orderBy != null) {
                return orderBy(query).ToList();
            }

            return query.ToList();
        }



    public IEnumerable<T> GetAll_2(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = _DbSet;
            if (filter != null) {
                query = query.Where(filter);
            }
            if (includeProperties != null) {
                foreach (var includepropertie in includeProperties.Split(new char[] { ',' } , StringSplitOptions.RemoveEmptyEntries)) {
                    query = query.Include(includepropertie);
                }
               
            }
            if (orderBy != null) {
                return orderBy(query).ToList();
            }

            return query;
        }



        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string IncludeProperties = null) {
            IQueryable<T> query = _DbSet;
            if (filter != null) {
                query = query.Where(filter);    
            }
            if (IncludeProperties != null) {
                foreach(var includeProperties in IncludeProperties.Split(new char[] {','} , StringSplitOptions.RemoveEmptyEntries)) 
                {
                    query = query.Include(includeProperties);
                }
            }
            return query.FirstOrDefault();
        }

        public void Remove(int id)
        {
            T entityToRemove = _DbSet.Find(id);
        }

        public void Remove(T entity)
        {
            _DbSet.Remove(entity);
        }






        #region

        public async Task AddAsync(T entity) { 
            await _DbSet.AddAsync(entity);
        }

        //  void Remove(T entity);
        public Task DeleteAsync(T entity)
        {
            _DbSet.Remove(entity);
            return Task.CompletedTask;
        }
        public Task DeleteManyAsync(Expression<Func<T, bool>> filter)
        {
            var entities = _DbSet.Where(filter);
            _DbSet.RemoveRange(entities);
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _DbSet.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = _DbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var includepropertie in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includepropertie);
                }

            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }

            // return await query.ToListAsync();
             return await query.AsNoTracking().ToListAsync();
        }




        public IEnumerable<T> GetPaginationAll(Expression<Func<T, bool>> filter = null,
                                       Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                       string includeProperties = null,
                                       string campos = null,
                                       string valorBuscado = null,
                                       int omitirRegistros = 0,
                                       int cantidadRegistros = 0) {


            // IQueryable<SolicitudRecepcion> querySolicitudRecepcion = _context.SolicitudRecepcions;
            // querySolicitudRecepcion = querySolicitudRecepcion.Where(e => string.Concat(e.IdEstatus).Contains(valor1));





            IQueryable<T> query = _DbSet;
            if (filter != null) {
                   query = query.Where(filter);

            }
            if (includeProperties != null)
            {
                foreach (var includepropertie in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includepropertie);
                }

            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }

            // return query.ToList();

            query = query.Skip(omitirRegistros).Take(cantidadRegistros).AsNoTracking();
            return query.ToList();
        }




        public async Task<T> GetByIdAsync(int id)
        {
            return await _DbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetManyAsync(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            int? top = null,
            int? skip = null,
            params string[] includeProperties)
        {
            IQueryable<T> query = _DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties.Length > 0)
            {
                query = includeProperties.Aggregate(query, (theQuery, theInclude) => theQuery.Include(theInclude));
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }

            if (top.HasValue)
            {
                query = query.Take(top.Value);
            }

            return await query.ToListAsync();
        }

        #endregion
    }