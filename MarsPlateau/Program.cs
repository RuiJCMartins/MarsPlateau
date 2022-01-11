using MarsPlateau.Models;
using System;
using System.Collections.Generic;

namespace MarsPlateau
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string[] limits = Console.ReadLine().Split(',');
                string commands = Console.ReadLine();

                Coordinates coordinates = new Coordinates();

                var commandDirections = Actions.SetCommandAndDirection();

                foreach (char command in commands)
                {
                    Actions.MoveForward(limits, coordinates, command);

                    if (commandDirections.ContainsKey(((Commands)command, coordinates.currentDirection)))
                    {
                        coordinates.currentDirection = commandDirections[((Commands)command, coordinates.currentDirection)];
                    }
                }

                Console.WriteLine($"{coordinates.X}, {coordinates.Y}, {coordinates.currentDirection}");
            }
        }
    }
}