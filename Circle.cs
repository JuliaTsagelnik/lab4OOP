using System;

namespace CircleMovementApp
{
    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; }
        private readonly int moveStep;

        public Circle(int initialX, int initialY, int radius, int moveStep)
        {
            X = initialX;
            Y = initialY;
            Radius = radius;
            this.moveStep = moveStep;
        }

        public void MoveUp(int panelHeight)
        {
            if (Y - moveStep >= Radius)
                Y -= moveStep;
        }

        public void MoveDown(int panelHeight)
        {
            if (Y + moveStep <= panelHeight - Radius)
                Y += moveStep;
        }

        public void MoveLeft()
        {
            if (X - moveStep >= Radius)
                X -= moveStep;
        }

        public void MoveRight(int panelWidth)
        {
            if (X + moveStep <= panelWidth - Radius)
                X += moveStep;
        }
    }
}// Обновлено для лабораторной 4
