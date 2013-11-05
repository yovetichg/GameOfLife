using NUnit.Framework;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class GridTests
    {
        [TestCase(4, 4)]
        [TestCase(1, 7)]
        public void It_should_have_the_correct_number_of_rows_and_columns(int rows, int columns)
        {
            var grid = new Grid(rows, columns);
            Assert.AreEqual(grid.Rows.Count, rows);
            Assert.AreEqual(grid.Rows[0].Cells.Count, columns);
        }

        [Test]
        public void It_should_have_all_dead_cells_at_start()
        {
            var grid = new Grid(5, 7);
            Assert.AreEqual(35, grid.GetDeadCellCount());
        }

        [Test]
        public void It_should_ressurect_a_cell()
        {
            var grid = new Grid(7, 5);
            grid.RessurectCellAt(4,6);
            Assert.AreEqual(1, grid.GetLivingCellCount());
            Assert.IsTrue(grid.GetCellAt(4,6).IsAlive);
            Assert.IsFalse(grid.GetCellAt(4,5).IsAlive);
        }
    }
}
