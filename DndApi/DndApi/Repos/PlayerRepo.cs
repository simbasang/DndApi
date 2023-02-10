using DndApi.Contexts;
using DndApi.Contracts.Models;
using DndApi.Contracts.Querys;
using DndApi.Contracts.Request;
using DndApi.Entitys;
using DndApi.Repos.Generic;
using DndApi.Repos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DndApi.Repos
{
    public class PlayerRepo : GenericRepo<PlayerEntity, PlayerQuery>, IPlayerRepo
    {
        public PlayerRepo(Context context) : base(context)
        {
        }

        protected override IQueryable<PlayerEntity> AddFilters(IQueryable<PlayerEntity> queryable, PlayerQuery query)
        {
            queryable = queryable.Include(x => x.Class);
            return queryable;
        }
    }
}
