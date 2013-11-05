using System;

namespace GameOfLife
{
    public class CellPosition
    {
        public int X { get; set; }
        public int Y { get; set; }

        public CellPosition(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
    }
}
