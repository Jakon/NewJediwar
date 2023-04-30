namespace NewJediwar.Shared
{
    public class CharacterPower
    {
        public string Name { get; set; }
        public int Range { get; set; }
        public int Damage { get; set; }

        public CharacterPower(string name, int range, int damage)
        {
            Name = name;
            Range = range;
            Damage = damage;
        }
    }
}
