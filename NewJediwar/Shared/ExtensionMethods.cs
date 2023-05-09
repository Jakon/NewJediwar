using NewJediwar.Shared.Entities;

namespace NewJediwar.Shared
{
    public static class ExtensionMethods
    {
        public static PlanetGround GetPlanetGround(this List<PlanetGround> list, int row, int column) 
        {
            return list.FirstOrDefault(pg => pg.Column == column && pg.Row == row);
        }
    }
}
