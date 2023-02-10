using DndApi.Entitys.Interfaces;
using DndApi.Entitys.JoinTables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DndApi.Entitys
{
    public class PlayerEntity : IAttributeEntity, IEntity
    {
        public Guid Id { get; set; } = new();
        public string Name { get; set; }
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


        //relations
        [ForeignKey("RaceEntity")]
        public Guid? RaceId { get; set; }
        public RaceEntity Race { get; set; }

        [ForeignKey("ClassEntity")]
        public Guid? ClassId { get; set; }
        public ClassEntity Class { get; set; }

        [ForeignKey("EquipmentEntity")]
        public Guid? EquipmentId { get; set; }
        public EquipmentEntity Equipment { get; set; }

        public List<PlayerSkillsEntity> Skills { get; set; } = new();
        //public string Bag { get; set; }
        //public string Attributes { get; set; }


    }
}
