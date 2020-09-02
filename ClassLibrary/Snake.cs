using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class SnakeClass
    {
        public int Length { get; set; } = 6;
        public Direction Direction { get; set; } = Direction.right;
        public Coordinates HeadPosition { get; set; } = new Coordinates();
        List<Coordinates> Tail { get; set; } = new List<Coordinates>();
        public bool outOfRange = false;

        public bool gameOver
        {
            get { return (Tail.Where(c => c.X == HeadPosition.X && c.Y == HeadPosition.Y).ToList().Count > 1) || outOfRange; }
        }
        

        public void Eat()
        {
            Length++;
        }

        public void Move()
        {
            switch(Direction)
            {
                case Direction.up:
                    HeadPosition.Y--;
                    break;
                case Direction.down:
                    HeadPosition.Y++;
                    break;
                case Direction.left:
                    HeadPosition.X--;
                    break;
                case Direction.right:
                    HeadPosition.X++;
                    break;
            }
            
            Console.SetCursorPosition(HeadPosition.X, HeadPosition.Y);
            Console.Write("o");
            Tail.Add(new Coordinates(HeadPosition.X, HeadPosition.Y));

            if (Tail.Count > this.Length)
            {
                var endTail = Tail.First();
                Console.SetCursorPosition(endTail.X, endTail.Y);
                Console.Write(" ");
                Tail.Remove(endTail);
            }

            if(HeadPosition.X == 1 || HeadPosition.X == Console.WindowWidth-1 || HeadPosition.Y == 2 || HeadPosition.Y == Console.WindowHeight-1)
            {
                outOfRange = true;
            }
            
            
        }
    }
    public enum Direction { left, right, up, down}
}
