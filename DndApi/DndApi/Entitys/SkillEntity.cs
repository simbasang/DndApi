using DndApi.Entitys.Interfaces;
using DndApi.Entitys.JoinTables;
using DndApi.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace DndApi.Entitys
{
    public class SkillEntity : IEntity
    {
        public Guid Id { get; set; } = new();
        public string Name { get; set; }
        public string Description { get; set; }
        public SkillEfectType SkillEfectType { get; set; }
        public AmountType AmountType { get; set; }
        public int EffectAmount { get; set; }
        public SkillType SkillType { get; set; }




        [ForeignKey("ClassEntity")]
        public Guid? ClassId { get; set; }
        public ClassEntity Class { get; set; }

        [ForeignKey("RaceEntity")]
        public Guid? RaceId { get; set; }
        public RaceEntity Race { get; set; }
    }
}
