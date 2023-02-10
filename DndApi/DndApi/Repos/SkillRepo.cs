using DndApi.Contexts;
using DndApi.Contracts.Querys;
using DndApi.Entitys;
using DndApi.Repos.Generic;
using DndApi.Repos.Interfaces;

namespace DndApi.Repos
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

            if (query.SkillEfectType != null)
                queryable = queryable.Where(x => x.SkillEfectType <= query.SkillEfectType);

            if (query.SkillType != null)
                queryable = queryable.Where(x => x.SkillType <= query.SkillType);

            if (query.ClassId != null)
                queryable = queryable.Where(x => x.ClassId == query.ClassId);

            if (query.RaceId != null)
                queryable = queryable.Where(x => x.RaceId == query.RaceId);

            return queryable;
        }
    }

}
