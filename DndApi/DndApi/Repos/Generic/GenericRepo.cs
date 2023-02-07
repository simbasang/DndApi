using DndApi.Contexts;
using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Entitys;
using DndApi.Entitys.Interfaces;
using DndApi.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DndApi.Repos.Generic
{
    public class GenericRepo<T, Tentity, Tquery> where T : class, IGenericRepo<T, Tentity, Tquery> where Tentity : class, IEntity
    {
        private readonly Context _context;
        private DbSet<Tentity> _table;

        public GenericRepo(Context context)
        {
            _context = context;
            _table = _context.Set<Tentity>();
        }


        public async Task<IEnumerable<Tentity>> Get(Tquery query)
        {
            return await _context.Set<Tentity>().Where(x => x.Id != new Guid()).ToListAsync();
        }


        public async Task<Tentity> Create(Tentity entity)
        {
            await _table.AddAsync(entity);

            return await _context.SaveChangesAsync() > 0 ? entity : null;
        }


        public async Task<Tentity> Update(Tentity entity)
        {
            var selectedEntity = _table.FirstOrDefault(x => x.Id == entity.Id);

            if (selectedEntity == null)
                return null;

            //update props
            var properties = typeof(Tentity).GetProperties();

            foreach (var prop in properties)
            {
                if (!prop.CanWrite)
                    continue;

                var value = prop.GetValue(entity, null);
                prop.SetValue(selectedEntity, value, null);
            }

            _context.Set<Tentity>().Update(selectedEntity);

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

    }
}
