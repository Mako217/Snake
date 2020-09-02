using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Frame
    {
        public int height { get; set; } = Console.WindowHeight;
        public int width { get; set; } = Console.WindowWidth;


        public void Draw()
        {
            
            for(int i = 1; i<width; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.WriteLine("_");
                Console.SetCursorPosition(i, height - 1);
                Console.WriteLine("_");
            }
            for(int i = 3; i<height; i++)
            {
                Console.SetCursorPosition(1, i);
                Console.WriteLine("|");
                Console.SetCursorPosition(width - 1, i);
                Console.WriteLine("|");
            }

        }
    }
}
