using DndApi.Entitys.Interfaces;

namespace DndApi.Entitys
{
    public class RaceEntity:IEntity
    {
        public Guid Id { get; set; }=new Guid();

        public string Name { get; set; }
        public List<SkillEntity> Skills { get; set; } = new();
        public string Description { get; set; }

    }
}
