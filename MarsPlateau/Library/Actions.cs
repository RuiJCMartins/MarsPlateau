using MarsPlateau.Models;
using System;

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

        public static Directions ChangeDirection(Directions currentDirection, char command)
        {
            Directions newDirection = new Directions();
            bool directionChanged = false;

            if (command == ((char)Commands.Left))
            {
                if (currentDirection == Directions.North)
                {
                    newDirection = Directions.West;
                }

                if (currentDirection == Directions.South)
                {
                    newDirection = Directions.East;
                }

                if (currentDirection == Directions.West)
                {
                    newDirection = Directions.South;
                }

                if (currentDirection == Directions.East)
                {
                    newDirection = Directions.North;
                }

                directionChanged = true;
            }

            if (command == ((char)Commands.Right))
            {
                if (currentDirection == Directions.North)
                {
                    newDirection = Directions.East;
                }

                if (currentDirection == Directions.South)
                {
                    newDirection = Directions.West;
                }

                if (currentDirection == Directions.West)
                {
                    newDirection = Directions.North;
                }

                if (currentDirection == Directions.East)
                {
                    newDirection = Directions.South;
                }

                directionChanged = true;
            }

            return directionChanged ? newDirection : currentDirection;
        }
    }
}