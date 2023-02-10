using DndApi.Enums;

namespace DndApi.Contracts.Request
{
    public class SkillRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public SkillEfectType? SkillEfectType { get; set; }
        public AmountType? AmountType { get; set; }
        public int? EffectAmount { get; set; }
        public SkillType? SkillType { get; set; }

        public Guid? ClassId { get; set; }
        public Guid? RaceId { get; set; }
    }
}
