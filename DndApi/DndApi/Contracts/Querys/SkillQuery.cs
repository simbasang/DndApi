using DndApi.Enums;

namespace DndApi.Contracts.Querys
{
    public class SkillQuery
    {
        public string? Name { get; set; }
        public SkillType? Type { get; set; }
        public AmountType? AmountType { get; set; }
        public int? EffectAmount { get; set; }
        public Guid? Id { get; set; }
    }
}
