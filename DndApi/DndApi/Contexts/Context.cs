using DndApi.Entitys;
using Microsoft.EntityFrameworkCore;

namespace DndApi.Contexts
{
    public class Context : DbContext
    {
        public DbSet<SkillEntity> Skills { get; set; }
        public Context():base()
        {

        }
    }
}
