namespace DndApi.Entitys
{
    public interface IAttributeEntity
    {
        //For melee dmg
        public int Strength { get; set; }
        //For extra hp
        public int Constitution { get; set; }
        //For range dmg
        public int Dexterity { get; set; }
        //For magic dmg
        public int Intelligens { get; set; }
        //For extra mana
        public int Wisdom { get; set; }
    }
}
