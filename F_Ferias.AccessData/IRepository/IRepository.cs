using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace F_Ferias.AccessData.IRepository; 
 public interface IRepository<T> where T : class {

        T Get(int id);

        T GetS(string id);
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
        );

          IEnumerable<T> GetPaginationAll(
          Expression<Func<T, bool>> filter = null,
          Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
          string includeProperties = null , 
          string campos = null ,
          string valorBuscado = null,
          int omitirRegistros = 0 , int cantidadRegistros = 0
      );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string IncludeProperties = null
        );
        void Add(T entity);
        void Remove(int id);
        void Remove(T entity);










        #region
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteManyAsync(Expression<Func<T, bool>> filter = null);

        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> filter = null,
                                         Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                         string includeProperties = null
        );


        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetManyAsync(Expression<Func<T, bool>> filter = null,
                                          Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                          int? top = null,
                                          int? skip = null,
                                          params string[] includeProperties);

        #endregion
    }