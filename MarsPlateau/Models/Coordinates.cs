using System.ComponentModel;

namespace MarsPlateau.Models
{
    public class Coordinates
    {
        public int X = 1;
        public int Y = 1;

        [DefaultValue(Directions.North)]
        public Directions currentDirection;
    }
}