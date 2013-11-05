using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameOfLife
{
    public class Grid
    {
        public List<Row> Rows { get; set; }

        public Grid(int rows, int columns)
        {
            Rows = new List<Row>();
            for (int i = 0; i < rows; i++)
            {
                var row = new Row(columns, i, i == rows - 1);
                Rows.Add(row);
            }
        }

        public void Start()
        {

        }

        public void NextGeneration()
        {
            foreach (var row in Rows)
            {
                foreach (var cell in row.Cells)
                {
                    cell.DetermineLivingNeighbors(this);
                }
            }
            foreach (var row in Rows)
            {
                foreach (var cell in row.Cells)
                {
                    cell.JudgmentDay();
                }
            }
        }

        public void PrintCellPositions()
        {
            foreach (var row in Rows)
            {
                foreach (var cell in row.Cells)
                {
                    Console.WriteLine("X:" + cell.Position.X + " Y:" + cell.Position.Y + (cell.IsAlive ? "alive" : "dead"));
                }
            }
        }

        public void Stop()
        {

        }

        public Cell GetCellAt(int x, int y)
        {
            return Rows[y].Cells[x];
        }

        public void KillCellAt(int x, int y)
        {
            Rows[y].Cells[x].Die();
        }

        public void RessurectCellAt(int x, int y)
        {
            Rows[y].Cells[x].Resurrect();
        }

        public int GetLivingCellCount()
        {
            var livingCells = 0;
            foreach (var row in Rows)
            {
                foreach (var cell in row.Cells)
                {
                    if (cell.IsAlive)
                    {
                        livingCells++;
                    }
                }
            }
            return livingCells;
        }

        public int GetDeadCellCount()
        {
            var deadCells = 0;
            foreach (var row in Rows)
            {
                foreach (var cell in row.Cells)
                {
                    if (!cell.IsAlive)
                    {
                        deadCells++;
                    }
                }
            }
            return deadCells;
        }

        public void ClearCells()
        {
            foreach (var row in Rows)
            {
                foreach (var cell in row.Cells)
                {
                    cell.Die();
                }
            }
        }

    }
}
