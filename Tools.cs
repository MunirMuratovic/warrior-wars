using System;

namespace WarriorWars
{
    class Tools
    {
        public static void ColorfulWriteline(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
