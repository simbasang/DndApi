using DndApi.Contexts;
using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Entitys;
using DndApi.Entitys.Interfaces;
using DndApi.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DndApi.Repos.Generic
{
    public abstract class GenericRepo<TEntity, TQuery>
        : IGenericRepo<TEntity, TQuery> where TEntity : class, IEntity
    {
        private readonly Context _context;
        private DbSet<TEntity> _table;
        protected IQueryable<TEntity> DbSetQueryable;


        public GenericRepo(Context context)
        {
            _context = context;
            _table = _context.Set<TEntity>();
            DbSetQueryable = _context.Set<TEntity>().AsQueryable();
        }


        public async Task<IEnumerable<TEntity>> Get(TQuery query)
        {
            return await AddFilters(DbSetQueryable, query).ToListAsync();
        }


        public async Task<TEntity> Create(TEntity entity)
        {
            await _table.AddAsync(entity);

            return await _context.SaveChangesAsync() > 0 ? entity : null;
        }


        public async Task<TEntity> Update(TEntity entity)
        {
            var selectedEntity = _table.FirstOrDefault(x => x.Id == entity.Id);

            if (selectedEntity == null)
                return null;

            //update props
            var properties = typeof(TEntity).GetProperties();

            foreach (var prop in properties)
            {
                if (!prop.CanWrite)
                    continue;

                var value = prop.GetValue(entity, null);
                prop.SetValue(selectedEntity, value, null);
            }

            _context.Set<TEntity>().Update(selectedEntity);

            return await _context.SaveChangesAsync() > 0 ? entity : null;

        }


        public async Task<bool> Delete(Guid id)
        {
            var task = await _table.FirstOrDefaultAsync(x => x.Id == id);

            if (task == null)
                return false;

            _table.Remove(task);

            return await _context.SaveChangesAsync() > 0 ? true : false;
        }


        /// <summary>
        /// This method need to be overriden to filter the get method 
        /// </summary>
        protected abstract IQueryable<TEntity> AddFilters(IQueryable<TEntity> queryable,
           TQuery query);

    }
}
