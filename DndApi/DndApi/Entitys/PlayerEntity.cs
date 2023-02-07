using System.ComponentModel.DataAnnotations;

namespace DndApi.Entitys
{
    public class PlayerEntity: IAttributeEntity
    {
        
        public Guid Id { get; set; } = new Guid();
        
        public string Name { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
        public string Skills { get; set; }
        public string Equipment { get; set; }
        public string Bag { get; set; }
        public string Attributes { get; set; }
        
        public int CurrentMana { get; set; }
        public int CurrentHealth { get; set; }
        
        public int Level { get; set; } = 1;
        public int Experience { get; set; } = 0;
        public int MaxMana { get; set; } = 100;
        public int MaxHealth { get; set; } = 500;

        //IAttributeEntity
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligens { get; set; }
        public int Wisdom { get; set; }
    }
}
