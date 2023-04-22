namespace NewJediwar.Shared
{
    public class JediwarPower
    {
        public string Name { get; set; }
        public int Range { get; set; }
        public int Damage { get; set; }

        public JediwarPower(string name, int range, int damage)
        {
            Name = name;
            Range = range;
            Damage = damage;
        }
    }
}
