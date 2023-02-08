using DndApi.Contexts;
using DndApi.Contracts.Querys;
using DndApi.Entitys;
using DndApi.Repos.Generic;
using DndApi.Repos.Interfaces;

namespace DndApi.Repos.EmptyRepos
{
    public class SkillRepo : GenericRepo<SkillEntity, SkillQuery>, ISkillRepo
    {
        public SkillRepo(Context context) : base(context)
        {
        }

        protected override IQueryable<SkillEntity> AddFilters(IQueryable<SkillEntity> queryable, SkillQuery query)
        {

            if (query.Id != null)
                queryable = queryable.Where(x => x.Id == query.Id);

            if (!string.IsNullOrEmpty(query.Name))
                queryable = queryable.Where(x => x.Name == query.Name);

            if (query.EffectAmount != null)
                queryable = queryable.Where(x => x.EffectAmount >= query.EffectAmount);

            if (query.AmountType != null)
                queryable = queryable.Where(x => x.AmountType <= query.AmountType);

            if (query.Type != null)
                queryable = queryable.Where(x => x.Type <= query.Type);

           
            return queryable;
        }
    }

}
