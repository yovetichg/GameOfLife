using NUnit.Framework;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class CellTests
    {

        [Test]
        public void A_dead_cell_with_exactly_three_living_neighbors_should_ressurect()
        {
            var grid = new Grid(4, 4);
            grid.RessurectCellAt(1, 1);
            grid.RessurectCellAt(1, 2);
            grid.RessurectCellAt(0, 2);

            /////////////////
            ////Start////////
            //  .   .   .   .
            //  .   *   .   .
            //  *   *   .   .
            //  .   .   .   .
            /////////////////

            grid.NextGeneration();
            
            /////////////////
            ////Finish///////
            //  .   .   .   .
            //  *   *   .   .
            //  *   *   .   .
            //  .   .   .   .
            /////////////////
            
            Assert.AreEqual(4, grid.GetLivingCellCount());
            Assert.IsTrue(grid.GetCellAt(1, 1).IsAlive);
            Assert.IsTrue(grid.GetCellAt(1, 2).IsAlive);
            Assert.IsTrue(grid.GetCellAt(0, 2).IsAlive);
            Assert.IsTrue(grid.GetCellAt(0, 1).IsAlive);
        }

        [Test]
        public void A_living_cell_with_fewer_than_two_living_neighbors_should_die()
        {
            var grid = new Grid(4, 4);
            grid.RessurectCellAt(1, 1);

            /////////////////
            ////Start////////
            //  .   .   .   .
            //  .   *   .   .
            //  .   .   .   .
            //  .   .   .   .
            /////////////////

            grid.NextGeneration();

            /////////////////
            ////Finish///////
            //  .   .   .   .
            //  .   .   .   .
            //  .   .   .   .
            //  .   .   .   .
            /////////////////

            Assert.AreEqual(0, grid.GetLivingCellCount());
            Assert.IsFalse(grid.GetCellAt(1, 1).IsAlive);
            
        }

        [Test]
        public void A_living_cell_with_more_than_three_living_neighbors_should_die()
        {
            var grid = new Grid(4, 4);
            grid.RessurectCellAt(1, 1);
            grid.RessurectCellAt(1, 2);
            grid.RessurectCellAt(1, 3);
            grid.RessurectCellAt(0, 2);
            grid.RessurectCellAt(2, 2);

            /////////////////
            ////Start////////
            //  .   .   .   .
            //  .   *   .   .
            //  *   *   *   .
            //  .   *   .   .
            /////////////////

            grid.NextGeneration();

            /////////////////
            ////Finish///////
            //  .   .   .   .
            //  *   *   *   .
            //  *   .   *   .
            //  *   *   *   .
            /////////////////

            Assert.AreEqual(8, grid.GetLivingCellCount());
            Assert.IsFalse(grid.GetCellAt(1, 2).IsAlive);

        }

        [Test]
        public void A_living_cell_with_exactly_three_living_neighbors_should_live_on()
        {
            var grid = new Grid(4, 4);
            grid.RessurectCellAt(0, 1);
            grid.RessurectCellAt(0, 2);
            grid.RessurectCellAt(1, 1);
            grid.RessurectCellAt(1, 2);

            /////////////////
            ////Start////////
            //  .   .   .   .
            //  *   *   .   .
            //  *   *   .   .
            //  .   .   .   .
            /////////////////

            grid.NextGeneration();

            /////////////////
            ////Finish///////
            //  .   .   .   .
            //  *   *   .   .
            //  *   *   .   .
            //  .   .   .   .
            /////////////////

            Assert.AreEqual(4, grid.GetLivingCellCount());
            Assert.IsTrue(grid.GetCellAt(0, 1).IsAlive);
            Assert.IsTrue(grid.GetCellAt(0, 2).IsAlive);
            Assert.IsTrue(grid.GetCellAt(1, 1).IsAlive);
            Assert.IsTrue(grid.GetCellAt(1, 2).IsAlive);

        }
    }

}
