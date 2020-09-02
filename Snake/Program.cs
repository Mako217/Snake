using System;
using System.Runtime.InteropServices.WindowsRuntime;
using ClassLibrary;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Console.CursorVisible = false;
            DrawFrame();
            bool exit = false;
            double refreshRate = 1000 / 5.0;
            DateTime lastTime = DateTime.Now;
            Food food = new Food();
            SnakeClass snake = new SnakeClass();
            while(!exit)
            {
                
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    switch(input.Key)
                    {
                        case ConsoleKey.Escape:
                            snake.gameOver = true;
                            break;
                        case ConsoleKey.UpArrow:
                            if (snake.Direction != Direction.down) 
                            snake.Direction = Direction.up;
                            break;
                        case ConsoleKey.DownArrow:
                            if (snake.Direction != Direction.up) 
                            snake.Direction = Direction.down;
                            break;
                        case ConsoleKey.LeftArrow:
                            if (snake.Direction != Direction.right) 
                            snake.Direction = Direction.left;
                            break;
                        case ConsoleKey.RightArrow:
                            if (snake.Direction != Direction.left) 
                            snake.Direction = Direction.right;
                            break;
                    }

                }

                if((DateTime.Now-lastTime).TotalMilliseconds>=refreshRate)
                {
                    snake.Move();
                    if(snake.HeadPosition.X == food.foodCoordinates.X && snake.HeadPosition.Y == food.foodCoordinates.Y)
                    {
                        snake.Eat();
                        food = new Food();
                        refreshRate /= 1.1;
                    }

                    if(snake.gameOver)
                    {
                        exit = true;
                        Console.Clear();
                        Console.WriteLine($"Game over! Your score: {snake.Length-1}");
                        Console.ReadLine();
                    }

                    lastTime = DateTime.Now;
                }
            }
           
        }
        public static void DrawFrame()
        {
            int height = Console.WindowHeight;
            int width = Console.WindowWidth;
            
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
