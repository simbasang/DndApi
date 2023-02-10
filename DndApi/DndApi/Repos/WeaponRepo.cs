using DndApi.Contexts;
using DndApi.Contracts.Querys;
using DndApi.Entitys;
using DndApi.Repos.Generic;
using DndApi.Repos.Interfaces;

namespace DndApi.Repos
{
    public class WeaponRepo : GenericRepo<WeaponEntity, WeaponQuery>, IWeaponRepo
    {
        public WeaponRepo(Context context) : base(context)
        {
        }

        protected override IQueryable<WeaponEntity> AddFilters(IQueryable<WeaponEntity> queryable, WeaponQuery query)
        {
            if (query.Id != null)
                queryable = queryable.Where(x => x.Id == query.Id);

            if (!string.IsNullOrEmpty(query.Name))
                queryable = queryable.Where(x => x.Name == query.Name);

            if (query.MinAttack != null)
                queryable = queryable.Where(x => x.Attack <= query.MinAttack);

            if (query.MaxAttack != null)
                queryable = queryable.Where(x => x.Attack >= query.MaxAttack);

            if (query.WeaponType != null)
                queryable = queryable.Where(x => x.WeaponType == query.WeaponType);

            if (query.MinRange != null)
                queryable = queryable.Where(x => x.Range >= query.MinRange);

            if (query.MaxRange != null)
                queryable = queryable.Where(x => x.Range <= query.MaxRange);

            if (query.IsTwoHanded != null)
                queryable = queryable.Where(x => x.IsTwoHanded == query.IsTwoHanded);

            return queryable;
        }
    }
}
