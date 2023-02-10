using DndApi.Entitys.Interfaces;
using DndApi.Enums;

namespace DndApi.Entitys
{
    public class WeaponEntity : IAttributeEntity, IEntity
    {
        public Guid Id { get; set; } = new ();
        public string Name { get; set; }
        public string Description { get; set; }
        public int Attack { get; set; }
        public WeaponType WeaponType { get; set; }
        public int Range { get; set; }
        public bool IsTwoHanded { get; set; }
      
        //IAttributeEntity
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligens { get; set; }
        public int Wisdom { get; set; }
    }
}
