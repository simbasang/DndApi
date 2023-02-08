using DndApi.Enums;

namespace DndApi.Contracts.Request
{
    public class ArmorRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ArmorType Type { get; set; }
        public int Armor { get; set; }
        public Rarity Rarity { get; set; }
    }
}
