using MarsPlateau.Models;
using System;

namespace MarsPlateau
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                string[] limits = Console.ReadLine().Split(',');
                string commands = Console.ReadLine();

                Coordinates coordinates = new Coordinates();

                foreach (char command in commands)
                {
                    Actions.MoveForward(limits, coordinates, command);

                    coordinates.currentDirection = Actions.ChangeDirection(coordinates.currentDirection, command);
                }

                Console.WriteLine($"{coordinates.X}, {coordinates.Y}, {coordinates.currentDirection}");
            }
        }
    }
}