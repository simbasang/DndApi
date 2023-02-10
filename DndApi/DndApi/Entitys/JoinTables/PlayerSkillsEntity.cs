using DndApi.Entitys.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace DndApi.Entitys.JoinTables
{
    public class PlayerSkillsEntity : IEntity
    {
        public Guid Id { get; set; } = new();

        [ForeignKey("SkillEntity")]
        public Guid? SkillId { get; set; }
        public SkillEntity Skill { get; set; }

        [ForeignKey("PlayerEntity")]
        public Guid? PlayerId { get; set; }
        public PlayerEntity Player { get; set; }
    }
}
