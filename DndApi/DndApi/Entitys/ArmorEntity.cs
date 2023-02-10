using DndApi.Entitys.Interfaces;
using DndApi.Enums;
using System.ComponentModel.DataAnnotations;

namespace DndApi.Entitys
{
    public class ArmorEntity : IAttributeEntity, IEntity
    {
        public Guid Id { get; set; } = new ();
        public string Name { get; set; }
        public string Description { get; set; }
        public ArmorType ArmorType { get; set; }
        public int Armor { get; set; }
        public Rarity Rarity { get; set; }

        //IAttributeEntity
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligens { get; set; }
        public int Wisdom { get; set; }
    }
}
