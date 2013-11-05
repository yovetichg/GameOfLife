using System;
using System.Windows.Forms;

namespace GameOfLife
{
    public class Cell
    {
        public Boolean IsAlive { get; set; }
        public CellType CellType { get; set; }
        public CellPosition Position { get; set; }
        public int LivingNeighborCount { get; set; }

        public Cell(int xPos, int yPos)
        {
            Position = new CellPosition(xPos, yPos);
        }

        public void JudgmentDay()
        {
            if (IsAlive)
            {
                if (LivingNeighborCount < 2 || LivingNeighborCount > 3)
                {
                    Die();
                }
            }
            else
            {
                if (LivingNeighborCount == 3)
                {
                    Resurrect();
                }
            }
        }

        public void DetermineLivingNeighbors(Grid grid)
        {
            switch (CellType)
            {
                case CellType.TopLeft:
                    LivingNeighborCount = GetTopLeftNeighbors(grid);
                    break;
                case CellType.TopMiddle:
                    LivingNeighborCount = GetTopMiddleNeighbors(grid);
                    break;
                case CellType.TopRight:
                    LivingNeighborCount = GetTopRightNeighbors(grid);
                    break;
                case CellType.RightMiddle:
                    LivingNeighborCount = GetRightMiddleNeighbors(grid);
                    break;
                case CellType.BottomRight:
                    LivingNeighborCount = GetBottomRightNeighbors(grid);
                    break;
                case CellType.BottomMiddle:
                    LivingNeighborCount = GetBottomMiddleNeighbors(grid);
                    break;
                case CellType.BottomLeft:
                    LivingNeighborCount = GetBottomLeftNeighbors(grid);
                    break;
                case CellType.LeftMiddle:
                    LivingNeighborCount = GetLeftMiddleNeighbors(grid);
                    break;
                case CellType.Center:
                    LivingNeighborCount = GetCenterNeighbors(grid);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private int GetCenterNeighbors(Grid grid)
        {
            var livingNeighbors = 0;
            if (grid.GetCellAt(Position.X - 1, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X + 1, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X + 1, Position.Y).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X + 1, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X - 1, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X - 1, Position.Y).IsAlive)
            {
                livingNeighbors++;
            }
            return livingNeighbors;
        }

        private int GetLeftMiddleNeighbors(Grid grid)
        {
            var livingNeighbors = 0;
            if (grid.GetCellAt(Position.X, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X + 1, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X + 1, Position.Y).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X + 1, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            return livingNeighbors;
        }

        private int GetBottomLeftNeighbors(Grid grid)
        {
            var livingNeighbors = 0;
            if (grid.GetCellAt(Position.X, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X + 1, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X + 1, Position.Y).IsAlive)
            {
                livingNeighbors++;
            }
            return livingNeighbors;
        }

        private int GetBottomMiddleNeighbors(Grid grid)
        {
            var livingNeighbors = 0;
            if (grid.GetCellAt(Position.X - 1, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X + 1, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X + 1, Position.Y).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X - 1, Position.Y).IsAlive)
            {
                livingNeighbors++;
            }
            return livingNeighbors;
        }

        private int GetBottomRightNeighbors(Grid grid)
        {
            var livingNeighbors = 0;
            if (grid.GetCellAt(Position.X - 1, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X - 1, Position.Y).IsAlive)
            {
                livingNeighbors++;
            }
            return livingNeighbors;
        }

        private int GetRightMiddleNeighbors(Grid grid)
        {
            var livingNeighbors = 0;
            if (grid.GetCellAt(Position.X - 1, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X, Position.Y - 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X - 1, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X - 1, Position.Y).IsAlive)
            {
                livingNeighbors++;
            }
            return livingNeighbors;
        }

        private int GetTopRightNeighbors(Grid grid)
        {
            var livingNeighbors = 0;
            if (grid.GetCellAt(Position.X, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X - 1, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X - 1, Position.Y).IsAlive)
            {
                livingNeighbors++;
            }
            return livingNeighbors;
        }

        private int GetTopMiddleNeighbors(Grid grid)
        {
            var livingNeighbors = 0;
            if (grid.GetCellAt(Position.X + 1, Position.Y).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X + 1, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X - 1, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X - 1, Position.Y).IsAlive)
            {
                livingNeighbors++;
            }
            return livingNeighbors;
        }

        private int GetTopLeftNeighbors(Grid grid)
        {
            var livingNeighbors = 0;
            if (grid.GetCellAt(Position.X + 1, Position.Y).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X + 1, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            if (grid.GetCellAt(Position.X, Position.Y + 1).IsAlive)
            {
                livingNeighbors++;
            }
            return livingNeighbors;
        }

        public void Die()
        {
            IsAlive = false;
        }

        public void Resurrect()
        {
            IsAlive = true;
        }
    }

}
