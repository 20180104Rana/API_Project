using Microsoft.EntityFrameworkCore;
using Store.Data.Contexts;
using Store.Data.Entities;
using Store.Reprosatory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Reprosatory.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        private readonly StoreDBContext _context;
        public GenericRepository(StoreDBContext context) 
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
            => await _context.Set<TEntity>().AddAsync(entity);

        public void Delete(TEntity entity)
            => _context.Set<TEntity>().Remove(entity);

        public async Task<IReadOnlyList<TEntity>> GetAllAsNoTrackingAsync()
            => await _context.Set<TEntity>().AsNoTracking().ToListAsync();

        public async Task<IReadOnlyList<TEntity>> GetAllAsync()
            => await _context.Set<TEntity>().ToListAsync();

        //public async Task<TEntity> GetByIdAsNoTrackingAsync(TKey? id)
        //    => await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        public async Task<TEntity> GetByIdAsync(TKey? id)
            => await _context.Set<TEntity>().FindAsync(id);

        public void Update(TEntity entity)
            => _context.Set<TEntity>().Update(entity);
    }
}
