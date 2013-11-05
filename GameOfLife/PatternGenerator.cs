using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameOfLife
{
    public class PatternGenerator
    {
        public static void InsertRandomLiveCells(Grid grid)
        {
            Random random = new Random();
            for (int i = 0; i < 55; i++)
            {
                grid.RessurectCellAt(random.Next(grid.Rows.Count), random.Next(grid.Rows[0].Cells.Count));
            }
        }

        public static void InsertPulsar(Grid grid)
        {
            grid.RessurectCellAt(2, 4);
            grid.RessurectCellAt(2, 5);
            grid.RessurectCellAt(2, 6);
            grid.RessurectCellAt(2, 10);
            grid.RessurectCellAt(2, 11);
            grid.RessurectCellAt(2, 12);

            grid.RessurectCellAt(4, 2);
            grid.RessurectCellAt(4, 7);
            grid.RessurectCellAt(4, 9);
            grid.RessurectCellAt(4, 14);

            grid.RessurectCellAt(5, 2);
            grid.RessurectCellAt(5, 7);
            grid.RessurectCellAt(5, 9);
            grid.RessurectCellAt(5, 14);

            grid.RessurectCellAt(6, 2);
            grid.RessurectCellAt(6, 7);
            grid.RessurectCellAt(6, 9);
            grid.RessurectCellAt(6, 14);

            grid.RessurectCellAt(7, 4);
            grid.RessurectCellAt(7, 5);
            grid.RessurectCellAt(7, 6);
            grid.RessurectCellAt(7, 10);
            grid.RessurectCellAt(7, 11);
            grid.RessurectCellAt(7, 12);

            grid.RessurectCellAt(9, 4);
            grid.RessurectCellAt(9, 5);
            grid.RessurectCellAt(9, 6);
            grid.RessurectCellAt(9, 10);
            grid.RessurectCellAt(9, 11);
            grid.RessurectCellAt(9, 12);

            grid.RessurectCellAt(10, 2);
            grid.RessurectCellAt(10, 7);
            grid.RessurectCellAt(10, 9);
            grid.RessurectCellAt(10, 14);

            grid.RessurectCellAt(11, 2);
            grid.RessurectCellAt(11, 7);
            grid.RessurectCellAt(11, 9);
            grid.RessurectCellAt(11, 14);

            grid.RessurectCellAt(12, 2);
            grid.RessurectCellAt(12, 7);
            grid.RessurectCellAt(12, 9);
            grid.RessurectCellAt(12, 14);

            grid.RessurectCellAt(14, 4);
            grid.RessurectCellAt(14, 5);
            grid.RessurectCellAt(14, 6);
            grid.RessurectCellAt(14, 10);
            grid.RessurectCellAt(14, 11);
            grid.RessurectCellAt(14, 12);
        }
    }
}