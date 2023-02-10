using DndApi.Entitys.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace DndApi.Entitys
{
    public class EquipmentEntity : IEntity
    {
        public Guid Id { get; set; } = new Guid();


        [ForeignKey("ArmorEntity")]
        public Guid? HeadId { get; set; }
        public ArmorEntity Head { get; set; }

        [ForeignKey("ArmorEntity")]
        public Guid? SholderId { get; set; }
        public ArmorEntity Sholder { get; set; }

        [ForeignKey("ArmorEntity")]
        public Guid? ChestId { get; set; }
        public ArmorEntity Chest { get; set; }

        [ForeignKey("ArmorEntity")]
        public Guid? HandsId { get; set; }
        public ArmorEntity Hands { get; set; }

        [ForeignKey("ArmorEntity")]
        public Guid? LegsId { get; set; }
        public ArmorEntity Legs { get; set; }

        [ForeignKey("ArmorEntity")]
        public Guid? FeetId { get; set; }
        public ArmorEntity Feet { get; set; }


    }
}
