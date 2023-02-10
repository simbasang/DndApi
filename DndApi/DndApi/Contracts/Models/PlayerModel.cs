using DndApi.Entitys;
using System.ComponentModel.DataAnnotations.Schema;

namespace DndApi.Contracts.Models
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public int CurrentMana { get; set; }
        public int CurrentHealth { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int MaxMana { get; set; }
        public int MaxHealth { get; set; }

        //IAttributeEntity
        public int Strength { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligens { get; set; }
        public int Wisdom { get; set; }


        //relations
        public Guid? ClassId { get; set; }
        public Guid? RaceId { get; set; }
        public List<Guid>? Skills { get; set; }
        public Guid? EquipmentId { get; set; }
    }
}
