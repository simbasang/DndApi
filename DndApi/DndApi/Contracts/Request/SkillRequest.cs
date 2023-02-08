using DndApi.Enums;

namespace DndApi.Contracts.Request
{
    public class SkillRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public SkillType? Type { get; set; }
        public AmountType? AmountType { get; set; }
        public int? EffectAmount { get; set; }
    }
}
