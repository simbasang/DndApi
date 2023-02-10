using DndApi.Enums;

namespace DndApi.Contracts.Querys
{
    public class SkillQuery
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public SkillEfectType? SkillEfectType { get; set; }
        public AmountType? AmountType { get; set; }
        public int? EffectAmount { get; set; }
        public SkillType? SkillType { get; set; }

        public Guid? ClassId { get; set; }
        public Guid? RaceId { get; set; }
    }
}
