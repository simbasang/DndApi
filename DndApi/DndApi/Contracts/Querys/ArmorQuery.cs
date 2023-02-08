using DndApi.Enums;

namespace DndApi.Contracts.Querys
{
    public class ArmorQuery
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public ArmorType? ArmorType { get; set; }
        public int? MinArmor { get; set; }
        public int? MaxArmor { get; set; }
        public Rarity? Rarity { get; set; }
    }
}
