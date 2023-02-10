using DndApi.Contexts;
using DndApi.Contracts.Querys;
using DndApi.Entitys;
using DndApi.Repos.Generic;
using DndApi.Repos.Interfaces;

namespace DndApi.Repos
{
    public class ArmorRepo : GenericRepo<ArmorEntity, ArmorQuery>, IArmorRepo
    {
        public ArmorRepo(Context context) : base(context)
        {
        }

        protected override IQueryable<ArmorEntity> AddFilters(IQueryable<ArmorEntity> queryable, ArmorQuery query)
        {

            if (query.Id != null)
                queryable = queryable.Where(x => x.Id == query.Id);

            if (!string.IsNullOrEmpty(query.Name))
                queryable = queryable.Where(x => x.Name == query.Name);

            if (query.Rarity != null)
                queryable = queryable.Where(x => x.Rarity == query.Rarity);

            if (query.ArmorType != null)
                queryable = queryable.Where(x => x.ArmorType == query.ArmorType);

            if (query.MinArmor != null)
                queryable = queryable.Where(x => x.Armor >= query.MinArmor);

            if (query.MaxArmor != null)
                queryable = queryable.Where(x => x.Armor <= query.MaxArmor);

            return queryable;
        }
    }
}
