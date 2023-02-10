using DndApi.Contexts;
using DndApi.Contracts.Querys;
using DndApi.Entitys;
using DndApi.Repos.Generic;
using DndApi.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DndApi.Repos
{
    public class ClassRepo : GenericRepo<ClassEntity, ClassQuery>, IClassRepo
    {
        public ClassRepo(Context context) : base(context)
        {
        }

        protected override IQueryable<ClassEntity> AddFilters(IQueryable<ClassEntity> queryable, ClassQuery query)
        {
            if (!string.IsNullOrEmpty(query.Name))
                queryable = queryable.Where(x => x.Name == query.Name);

            if (query.Id != null)
                queryable = queryable.Where(x => x.Id == query.Id);

            queryable = queryable.Include(x => x.Skills);

            return queryable;
        }
    }
}
