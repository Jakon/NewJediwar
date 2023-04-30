namespace NewJediwar.Shared
{
    public class GroundEnvironment
    {
        public string Name { get; set; }

        public string TextureName { get; set; }

        public bool IsPracticable { get; set; }

        public bool IsBuildable { get; set; }

        public string Color { get; set; }


        public string GetColorHex()
        {
            return $"#{Color}";
        }
    }
}
