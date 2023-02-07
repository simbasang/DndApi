using DndApi.Entitys.Interfaces;
using DndApi.Enums;

namespace DndApi.Entitys
{
    public class SkillEntity : IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SkillType Type { get; set; }
        public AmountType AmountType { get; set; }
        public int EffectAmount { get; set; }
        public Guid Id { get; set; }
    }
}
