using DndApi.Entitys.Interfaces;
using DndApi.Enums;

namespace DndApi.Entitys
{
    public class ArmorEntity : IEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public ArmorType ArmorType { get; set; }
        public int Armor { get; set; }
        public Rarity Rarity { get; set; }
    }
}
