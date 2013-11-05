using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        private const int TileSize = 40;
        private const int GridSize = 17;
        private Grid grid;
        private Panel[,] cellpPanels;
        private readonly Color _liveColor = Color.DarkGray;
        private readonly Color _deadColor = Color.White;
        private readonly Timer _timer = new Timer();
        private readonly SoundPlayer _soundPlayer = new SoundPlayer(GameOfLife.Properties.Resources.odyssey);

        public Form1()
        {
            InitializeComponent();
            InitGameBoard();
        }

        private void InitGameBoard()
        {
            grid = new Grid(GridSize, GridSize);
            cellpPanels = new Panel[GridSize, GridSize];

            _gameBoard.Width = GridSize * TileSize + (6 * (GridSize + 1));
            _gameBoard.Height = GridSize * TileSize + (6 * (GridSize + 1));

            for (var n = 0; n < grid.Rows.Count; n++)
            {
                for (var m = 0; m < grid.Rows[n].Cells.Count; m++)
                {
                    var newPanel = new Panel
                    {
                        Size = new Size(TileSize, TileSize),
                        Location = new Point(TileSize * n, TileSize * m)
                    };

                    _gameBoard.Controls.Add(newPanel);

                    cellpPanels[m, n] = newPanel;

                    newPanel.BackColor = grid.GetCellAt(m, n).IsAlive ? _liveColor : _deadColor;
                }
            }

            PatternGenerator.InsertRandomLiveCells(grid);
            Repaint();
        }


        private void _startBtn_Click(object sender, EventArgs e)
        {
            _soundPlayer.Play();
            StartTimer();
        }


        private void _stopBtn_Click(object sender, EventArgs e)
        {
            _soundPlayer.Stop();
            StopTimer();
        }

        private void _stepBtn_Click(object sender, EventArgs e)
        {
            grid.NextGeneration();
            Repaint();
        }

        private void _resetBtn_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            grid.ClearCells();
            PatternGenerator.InsertRandomLiveCells(grid);
            Repaint();
        }

        private void _pulsarBtn_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _soundPlayer.Stop();
            grid.ClearCells();
            PatternGenerator.InsertPulsar(grid);
            Repaint();
            StartTimer();
        }

        public void Repaint()
        {
            for (var n = 0; n < grid.Rows.Count; n++)
            {
                for (var m = 0; m < grid.Rows[n].Cells.Count; m++)
                {
                    cellpPanels[m, n].BackColor = grid.GetCellAt(m, n).IsAlive ? _liveColor : _deadColor;
                }
            }
            _gameBoard.Refresh();
        }

        private void StartTimer()
        {
            _timer.Tick += timer_Tick;
            _timer.Interval = 571;
            _timer.Enabled = true;
            _timer.Start();

        }

        private void StopTimer()
        {
            _timer.Tick -= timer_Tick;
            _timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            grid.NextGeneration();
            Repaint();
        }



    }
}
