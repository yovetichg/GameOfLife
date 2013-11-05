using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GameOfLife
{
    public class Row
    {
        public List<Cell> Cells { get; set; }
        private int _width;
        private bool _isBottomRow;

        public Row(int columns, int yPos, bool isBottomRow)
        {
            _width = columns;
            _isBottomRow = isBottomRow;
            Cells = new List<Cell>();
            for (int i = 0; i < columns; i++)
            {
                var cell = new Cell(i, yPos);
                cell.CellType = SetCellType(i, yPos);
                Cells.Add(cell);
            }
        }

        private CellType SetCellType(int xPos, int yPos)
        {
            if (xPos == _width - 1 && yPos == 0)
            {
                return CellType.TopRight;
            }
            else if (xPos == 0 && yPos == 0)
            {
                return CellType.TopLeft;
            }
            else if (yPos == 0)
            {
                return CellType.TopMiddle;
            }
            else if (xPos == 0 && _isBottomRow)
            {
                return CellType.BottomLeft;
            }
            else if (xPos == _width - 1 && _isBottomRow)
            {
                return CellType.BottomRight;
            }
            else if (_isBottomRow)
            {
                return CellType.BottomMiddle;
            }
            else if (xPos == 0)
            {
                return CellType.LeftMiddle;
            }
            else if (xPos == _width - 1)
            {
                return CellType.RightMiddle;
            }
            return CellType.Center;
        }
    }
}
