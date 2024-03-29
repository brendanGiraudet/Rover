﻿using Library.Enum;

namespace Library.Class
{
    public class Rover
    {
        public Direction DirectionGaze { get; set; }
        public Point Position { get; set; } = new Point();
        protected virtual int Speed { get; set; } = 1;

        public void Move(Movement movement)
        {
            int value;
            if (movement == Movement.Forward)
            {
                value = Speed;
            }
            else
            {
                value = -Speed;
            }

            switch (DirectionGaze)
            {
                case Direction.North:
                    Position.Y += value;
                    break;
                case Direction.East:
                    Position.X += value;
                    break;
                case Direction.South:
                    Position.Y -= value;
                    break;
                case Direction.West:
                    Position.X -= value;
                    break;
                default:
                    break;
            }
        }

        public void Turn(Movement movement)
        {
            var value = 1;
            if (movement == Movement.Left)
            {
                value = 3;
            }
            
            DirectionGaze = (Direction)(((int)DirectionGaze + value) % 4);
        }
    }
}
