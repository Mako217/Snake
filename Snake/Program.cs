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
            Frame frame = new Frame();
            frame.Draw();
            bool exit = false;
            double refreshRate = 1000 / 5.0;
            DateTime lastTime = DateTime.Now;
            Food food = new Food();
            SnakeClass snake = new SnakeClass();
            while(!exit)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 7 , 1);
                Console.Write($"Score : {snake.Length-1}");

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    switch(input.Key)
                    {
                        case ConsoleKey.Escape:
                            snake.outOfRange = true;
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
    }
}
