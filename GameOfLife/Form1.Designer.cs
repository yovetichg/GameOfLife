namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._startBtn = new System.Windows.Forms.Button();
            this._gameBoard = new System.Windows.Forms.FlowLayoutPanel();
            this._stepBtn = new System.Windows.Forms.Button();
            this._stopBtn = new System.Windows.Forms.Button();
            this._resetBtn = new System.Windows.Forms.Button();
            this._pulsarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _startBtn
            // 
            this._startBtn.Image = ((System.Drawing.Image)(resources.GetObject("_startBtn.Image")));
            this._startBtn.Location = new System.Drawing.Point(12, 12);
            this._startBtn.Name = "_startBtn";
            this._startBtn.Size = new System.Drawing.Size(24, 24);
            this._startBtn.TabIndex = 0;
            this._startBtn.UseVisualStyleBackColor = true;
            this._startBtn.Click += new System.EventHandler(this._startBtn_Click);
            // 
            // _gameBoard
            // 
            this._gameBoard.Location = new System.Drawing.Point(12, 94);
            this._gameBoard.Name = "_gameBoard";
            this._gameBoard.Size = new System.Drawing.Size(798, 383);
            this._gameBoard.TabIndex = 1;
            // 
            // _stepBtn
            // 
            this._stepBtn.Image = ((System.Drawing.Image)(resources.GetObject("_stepBtn.Image")));
            this._stepBtn.Location = new System.Drawing.Point(72, 12);
            this._stepBtn.Name = "_stepBtn";
            this._stepBtn.Size = new System.Drawing.Size(24, 24);
            this._stepBtn.TabIndex = 2;
            this._stepBtn.UseVisualStyleBackColor = true;
            this._stepBtn.Click += new System.EventHandler(this._stepBtn_Click);
            // 
            // _stopBtn
            // 
            this._stopBtn.Image = ((System.Drawing.Image)(resources.GetObject("_stopBtn.Image")));
            this._stopBtn.Location = new System.Drawing.Point(42, 11);
            this._stopBtn.Name = "_stopBtn";
            this._stopBtn.Size = new System.Drawing.Size(24, 24);
            this._stopBtn.TabIndex = 3;
            this._stopBtn.UseVisualStyleBackColor = true;
            this._stopBtn.Click += new System.EventHandler(this._stopBtn_Click);
            // 
            // _resetBtn
            // 
            this._resetBtn.Image = ((System.Drawing.Image)(resources.GetObject("_resetBtn.Image")));
            this._resetBtn.Location = new System.Drawing.Point(102, 12);
            this._resetBtn.Name = "_resetBtn";
            this._resetBtn.Size = new System.Drawing.Size(24, 24);
            this._resetBtn.TabIndex = 4;
            this._resetBtn.UseVisualStyleBackColor = true;
            this._resetBtn.Click += new System.EventHandler(this._resetBtn_Click);
            // 
            // _pulsarBtn
            // 
            this._pulsarBtn.Image = ((System.Drawing.Image)(resources.GetObject("_pulsarBtn.Image")));
            this._pulsarBtn.Location = new System.Drawing.Point(746, 12);
            this._pulsarBtn.Name = "_pulsarBtn";
            this._pulsarBtn.Size = new System.Drawing.Size(64, 64);
            this._pulsarBtn.TabIndex = 5;
            this._pulsarBtn.UseVisualStyleBackColor = true;
            this._pulsarBtn.Click += new System.EventHandler(this._pulsarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 915);
            this.Controls.Add(this._pulsarBtn);
            this.Controls.Add(this._resetBtn);
            this.Controls.Add(this._stopBtn);
            this.Controls.Add(this._stepBtn);
            this.Controls.Add(this._gameBoard);
            this.Controls.Add(this._startBtn);
            this.Name = "Form1";
            this.Text = "Game Of Life";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _startBtn;
        private System.Windows.Forms.FlowLayoutPanel _gameBoard;
        private System.Windows.Forms.Button _stepBtn;
        private System.Windows.Forms.Button _stopBtn;
        private System.Windows.Forms.Button _resetBtn;
        private System.Windows.Forms.Button _pulsarBtn;
    }
}

