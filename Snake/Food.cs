using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Snake
{
    public class Food
    {
        public Coordinates foodCoordinates { get; set; }

        public Food()
        {
            Random random = new Random();
            var x = random.Next(4, Console.WindowWidth - 2);
            var y = random.Next(4, Console.WindowHeight - 2);

            foodCoordinates = new Coordinates(x, y);
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(foodCoordinates.X, foodCoordinates.Y);
            Console.Write("x");
        }
    }
}
