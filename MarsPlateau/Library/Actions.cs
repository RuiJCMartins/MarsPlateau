using MarsPlateau.Models;
using System.Collections.Generic;

namespace MarsPlateau
{
    class Actions
    {
        public static void MoveForward(string[] limits, Coordinates coordinates, char command)
        {
            if (command == ((char)Commands.Forward))
            {
                if (coordinates.currentDirection == Directions.North & coordinates.Y < int.Parse(limits[0]))
                {
                    coordinates.Y++;
                }

                if (coordinates.currentDirection == Directions.South && coordinates.Y > 1)
                {
                    coordinates.Y--;
                }

                if (coordinates.currentDirection == Directions.West && coordinates.X > 1)
                {
                    coordinates.X--;
                }

                if (coordinates.currentDirection == Directions.East && coordinates.X < int.Parse(limits[1]))
                {
                    coordinates.X++;
                }
            }
        }

        public static Dictionary<(Commands, Directions), Directions> SetCommandAndDirection()
        {
            return new Dictionary<(Commands, Directions), Directions>
                {
                    { (Commands.Left, Directions.North), Directions.West },
                    { (Commands.Right, Directions.South), Directions.West },

                    { (Commands.Left, Directions.South), Directions.East },
                    { (Commands.Right, Directions.North), Directions.East },

                    { (Commands.Left, Directions.West), Directions.South },
                    { (Commands.Right, Directions.East), Directions.South },

                    { (Commands.Left, Directions.East), Directions.North },
                    { (Commands.Right, Directions.West), Directions.North }
                };
        }
    }
}