using DndApi.Entitys.Interfaces;

namespace DndApi.Entitys
{
    public class ClassEntity : IAttributeEntity, IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public List<SkillEntity> Skills { get; set; } = new();
        public string Description { get; set; }

        //IAttributeEntity
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligens { get; set; }
        public int Wisdom { get; set; }
    }
}
