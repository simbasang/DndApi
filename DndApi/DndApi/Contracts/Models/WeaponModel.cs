using DndApi.Enums;

namespace DndApi.Contracts.Models
{
    public class WeaponModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Attack { get; set; }
        public WeaponType WeaponType { get; set; }
        public int Range { get; set; }
        public bool IsTwoHanded { get; set; }
    }
}
