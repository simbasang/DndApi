using DndApi.Enums;

namespace DndApi.Contracts.Querys
{
    public class WeaponQuery
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public int? MinAttack { get; set; }
        public int? MaxAttack { get; set; }
        public WeaponType? WeaponType { get; set; }
        public int? MinRange { get; set; }
        public int? MaxRange { get; set; }
        public bool? IsTwoHanded { get; set; }
    }
}
