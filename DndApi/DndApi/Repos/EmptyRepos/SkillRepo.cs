using DndApi.Contexts;
using DndApi.Contracts.Querys;
using DndApi.Entitys;
using DndApi.Repos.Generic;
using DndApi.Repos.Interfaces;

namespace DndApi.Repos.EmptyRepos
{
    public class SkillRepo : GenericRepo<SkillRepo, SkillEntity, SkillQuery>, ISkillRepo
    {
        public SkillRepo(Context context) : base(context)
        {
        }
    }

}
