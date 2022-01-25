namespace WindowsFormsApp_DiceGame
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
            this.groupBox1FirstPlayer = new System.Windows.Forms.GroupBox();
            this.Dice1FirstPlayer = new System.Windows.Forms.Label();
            this.Dice1FirstPlayerValue = new System.Windows.Forms.Label();
            this.Dice2FirstPlayer = new System.Windows.Forms.Label();
            this.Dice2FirstPlayerValue = new System.Windows.Forms.Label();
            this.TotalPointFirstPlayer = new System.Windows.Forms.Label();
            this.TotalPointFirstPlayerValue = new System.Windows.Forms.Label();
            this.button1FirstPlayer = new System.Windows.Forms.Button();
            this.groupBox2SecondPlayer = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TotalPointSecondPlayerValue = new System.Windows.Forms.Label();
            this.TotalPointSecondPlayer = new System.Windows.Forms.Label();
            this.Dice2SecondPlayerValue = new System.Windows.Forms.Label();
            this.Dice2SecondPlayer = new System.Windows.Forms.Label();
            this.Dice1SecondPlayerValue = new System.Windows.Forms.Label();
            this.Dice1SecondPlayer = new System.Windows.Forms.Label();
            this.GroupBox3PointTable = new System.Windows.Forms.GroupBox();
            this.SecondPlayerPointTableValue = new System.Windows.Forms.Label();
            this.SecondPlayerPointTable = new System.Windows.Forms.Label();
            this.FirstPlayerPointTableValue = new System.Windows.Forms.Label();
            this.FirstPlayerPointTable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PointTableWinner = new System.Windows.Forms.Label();
            this.groupBox1FirstPlayer.SuspendLayout();
            this.groupBox2SecondPlayer.SuspendLayout();
            this.GroupBox3PointTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1FirstPlayer
            // 
            this.groupBox1FirstPlayer.BackColor = System.Drawing.Color.HotPink;
            this.groupBox1FirstPlayer.Controls.Add(this.button1FirstPlayer);
            this.groupBox1FirstPlayer.Controls.Add(this.TotalPointFirstPlayerValue);
            this.groupBox1FirstPlayer.Controls.Add(this.TotalPointFirstPlayer);
            this.groupBox1FirstPlayer.Controls.Add(this.Dice2FirstPlayerValue);
            this.groupBox1FirstPlayer.Controls.Add(this.Dice2FirstPlayer);
            this.groupBox1FirstPlayer.Controls.Add(this.Dice1FirstPlayerValue);
            this.groupBox1FirstPlayer.Controls.Add(this.Dice1FirstPlayer);
            this.groupBox1FirstPlayer.Location = new System.Drawing.Point(13, 12);
            this.groupBox1FirstPlayer.Name = "groupBox1FirstPlayer";
            this.groupBox1FirstPlayer.Size = new System.Drawing.Size(385, 165);
            this.groupBox1FirstPlayer.TabIndex = 0;
            this.groupBox1FirstPlayer.TabStop = false;
            this.groupBox1FirstPlayer.Text = "First Player";
            // 
            // Dice1FirstPlayer
            // 
            this.Dice1FirstPlayer.AutoSize = true;
            this.Dice1FirstPlayer.Location = new System.Drawing.Point(18, 32);
            this.Dice1FirstPlayer.Name = "Dice1FirstPlayer";
            this.Dice1FirstPlayer.Size = new System.Drawing.Size(86, 16);
            this.Dice1FirstPlayer.TabIndex = 1;
            this.Dice1FirstPlayer.Text = "Dice 1 Value:";
            // 
            // Dice1FirstPlayerValue
            // 
            this.Dice1FirstPlayerValue.AutoSize = true;
            this.Dice1FirstPlayerValue.Location = new System.Drawing.Point(110, 32);
            this.Dice1FirstPlayerValue.Name = "Dice1FirstPlayerValue";
            this.Dice1FirstPlayerValue.Size = new System.Drawing.Size(21, 16);
            this.Dice1FirstPlayerValue.TabIndex = 2;
            this.Dice1FirstPlayerValue.Text = "00";
            // 
            // Dice2FirstPlayer
            // 
            this.Dice2FirstPlayer.AutoSize = true;
            this.Dice2FirstPlayer.Location = new System.Drawing.Point(242, 32);
            this.Dice2FirstPlayer.Name = "Dice2FirstPlayer";
            this.Dice2FirstPlayer.Size = new System.Drawing.Size(86, 16);
            this.Dice2FirstPlayer.TabIndex = 3;
            this.Dice2FirstPlayer.Text = "Dice 2 Value:";
            // 
            // Dice2FirstPlayerValue
            // 
            this.Dice2FirstPlayerValue.AutoSize = true;
            this.Dice2FirstPlayerValue.Location = new System.Drawing.Point(343, 32);
            this.Dice2FirstPlayerValue.Name = "Dice2FirstPlayerValue";
            this.Dice2FirstPlayerValue.Size = new System.Drawing.Size(21, 16);
            this.Dice2FirstPlayerValue.TabIndex = 4;
            this.Dice2FirstPlayerValue.Text = "00";
            // 
            // TotalPointFirstPlayer
            // 
            this.TotalPointFirstPlayer.AutoSize = true;
            this.TotalPointFirstPlayer.Location = new System.Drawing.Point(118, 87);
            this.TotalPointFirstPlayer.Name = "TotalPointFirstPlayer";
            this.TotalPointFirstPlayer.Size = new System.Drawing.Size(71, 16);
            this.TotalPointFirstPlayer.TabIndex = 5;
            this.TotalPointFirstPlayer.Text = "Total Point";
            // 
            // TotalPointFirstPlayerValue
            // 
            this.TotalPointFirstPlayerValue.AutoSize = true;
            this.TotalPointFirstPlayerValue.Location = new System.Drawing.Point(217, 87);
            this.TotalPointFirstPlayerValue.Name = "TotalPointFirstPlayerValue";
            this.TotalPointFirstPlayerValue.Size = new System.Drawing.Size(21, 16);
            this.TotalPointFirstPlayerValue.TabIndex = 6;
            this.TotalPointFirstPlayerValue.Text = "00";
            // 
            // button1FirstPlayer
            // 
            this.button1FirstPlayer.Location = new System.Drawing.Point(146, 124);
            this.button1FirstPlayer.Name = "button1FirstPlayer";
            this.button1FirstPlayer.Size = new System.Drawing.Size(75, 23);
            this.button1FirstPlayer.TabIndex = 1;
            this.button1FirstPlayer.Text = "Start";
            this.button1FirstPlayer.UseVisualStyleBackColor = true;
            this.button1FirstPlayer.Click += new System.EventHandler(this.button1FirstPlayer_Click);
            // 
            // groupBox2SecondPlayer
            // 
            this.groupBox2SecondPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2SecondPlayer.Controls.Add(this.button1);
            this.groupBox2SecondPlayer.Controls.Add(this.TotalPointSecondPlayerValue);
            this.groupBox2SecondPlayer.Controls.Add(this.TotalPointSecondPlayer);
            this.groupBox2SecondPlayer.Controls.Add(this.Dice2SecondPlayerValue);
            this.groupBox2SecondPlayer.Controls.Add(this.Dice2SecondPlayer);
            this.groupBox2SecondPlayer.Controls.Add(this.Dice1SecondPlayerValue);
            this.groupBox2SecondPlayer.Controls.Add(this.Dice1SecondPlayer);
            this.groupBox2SecondPlayer.Location = new System.Drawing.Point(13, 208);
            this.groupBox2SecondPlayer.Name = "groupBox2SecondPlayer";
            this.groupBox2SecondPlayer.Size = new System.Drawing.Size(386, 165);
            this.groupBox2SecondPlayer.TabIndex = 7;
            this.groupBox2SecondPlayer.TabStop = false;
            this.groupBox2SecondPlayer.Text = "Second Player";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalPointSecondPlayerValue
            // 
            this.TotalPointSecondPlayerValue.AutoSize = true;
            this.TotalPointSecondPlayerValue.Location = new System.Drawing.Point(217, 87);
            this.TotalPointSecondPlayerValue.Name = "TotalPointSecondPlayerValue";
            this.TotalPointSecondPlayerValue.Size = new System.Drawing.Size(21, 16);
            this.TotalPointSecondPlayerValue.TabIndex = 6;
            this.TotalPointSecondPlayerValue.Text = "00";
            // 
            // TotalPointSecondPlayer
            // 
            this.TotalPointSecondPlayer.AutoSize = true;
            this.TotalPointSecondPlayer.Location = new System.Drawing.Point(118, 87);
            this.TotalPointSecondPlayer.Name = "TotalPointSecondPlayer";
            this.TotalPointSecondPlayer.Size = new System.Drawing.Size(71, 16);
            this.TotalPointSecondPlayer.TabIndex = 5;
            this.TotalPointSecondPlayer.Text = "Total Point";
            // 
            // Dice2SecondPlayerValue
            // 
            this.Dice2SecondPlayerValue.AutoSize = true;
            this.Dice2SecondPlayerValue.Location = new System.Drawing.Point(343, 32);
            this.Dice2SecondPlayerValue.Name = "Dice2SecondPlayerValue";
            this.Dice2SecondPlayerValue.Size = new System.Drawing.Size(21, 16);
            this.Dice2SecondPlayerValue.TabIndex = 4;
            this.Dice2SecondPlayerValue.Text = "00";
            // 
            // Dice2SecondPlayer
            // 
            this.Dice2SecondPlayer.AutoSize = true;
            this.Dice2SecondPlayer.Location = new System.Drawing.Point(242, 32);
            this.Dice2SecondPlayer.Name = "Dice2SecondPlayer";
            this.Dice2SecondPlayer.Size = new System.Drawing.Size(86, 16);
            this.Dice2SecondPlayer.TabIndex = 3;
            this.Dice2SecondPlayer.Text = "Dice 2 Value:";
            // 
            // Dice1SecondPlayerValue
            // 
            this.Dice1SecondPlayerValue.AutoSize = true;
            this.Dice1SecondPlayerValue.Location = new System.Drawing.Point(110, 32);
            this.Dice1SecondPlayerValue.Name = "Dice1SecondPlayerValue";
            this.Dice1SecondPlayerValue.Size = new System.Drawing.Size(21, 16);
            this.Dice1SecondPlayerValue.TabIndex = 2;
            this.Dice1SecondPlayerValue.Text = "00";
            // 
            // Dice1SecondPlayer
            // 
            this.Dice1SecondPlayer.AutoSize = true;
            this.Dice1SecondPlayer.Location = new System.Drawing.Point(18, 32);
            this.Dice1SecondPlayer.Name = "Dice1SecondPlayer";
            this.Dice1SecondPlayer.Size = new System.Drawing.Size(86, 16);
            this.Dice1SecondPlayer.TabIndex = 1;
            this.Dice1SecondPlayer.Text = "Dice 1 Value:";
            // 
            // GroupBox3PointTable
            // 
            this.GroupBox3PointTable.BackColor = System.Drawing.Color.PaleGreen;
            this.GroupBox3PointTable.Controls.Add(this.PointTableWinner);
            this.GroupBox3PointTable.Controls.Add(this.SecondPlayerPointTableValue);
            this.GroupBox3PointTable.Controls.Add(this.SecondPlayerPointTable);
            this.GroupBox3PointTable.Controls.Add(this.FirstPlayerPointTableValue);
            this.GroupBox3PointTable.Controls.Add(this.FirstPlayerPointTable);
            this.GroupBox3PointTable.Location = new System.Drawing.Point(420, 208);
            this.GroupBox3PointTable.Name = "GroupBox3PointTable";
            this.GroupBox3PointTable.Size = new System.Drawing.Size(392, 165);
            this.GroupBox3PointTable.TabIndex = 8;
            this.GroupBox3PointTable.TabStop = false;
            this.GroupBox3PointTable.Text = "Point Table";
            // 
            // SecondPlayerPointTableValue
            // 
            this.SecondPlayerPointTableValue.AutoSize = true;
            this.SecondPlayerPointTableValue.Location = new System.Drawing.Point(329, 32);
            this.SecondPlayerPointTableValue.Name = "SecondPlayerPointTableValue";
            this.SecondPlayerPointTableValue.Size = new System.Drawing.Size(21, 16);
            this.SecondPlayerPointTableValue.TabIndex = 4;
            this.SecondPlayerPointTableValue.Text = "00";
            // 
            // SecondPlayerPointTable
            // 
            this.SecondPlayerPointTable.AutoSize = true;
            this.SecondPlayerPointTable.Location = new System.Drawing.Point(224, 32);
            this.SecondPlayerPointTable.Name = "SecondPlayerPointTable";
            this.SecondPlayerPointTable.Size = new System.Drawing.Size(99, 16);
            this.SecondPlayerPointTable.TabIndex = 3;
            this.SecondPlayerPointTable.Text = "Second Player:";
            // 
            // FirstPlayerPointTableValue
            // 
            this.FirstPlayerPointTableValue.AutoSize = true;
            this.FirstPlayerPointTableValue.Location = new System.Drawing.Point(101, 32);
            this.FirstPlayerPointTableValue.Name = "FirstPlayerPointTableValue";
            this.FirstPlayerPointTableValue.Size = new System.Drawing.Size(21, 16);
            this.FirstPlayerPointTableValue.TabIndex = 2;
            this.FirstPlayerPointTableValue.Text = "00";
            // 
            // FirstPlayerPointTable
            // 
            this.FirstPlayerPointTable.AutoSize = true;
            this.FirstPlayerPointTable.Location = new System.Drawing.Point(18, 32);
            this.FirstPlayerPointTable.Name = "FirstPlayerPointTable";
            this.FirstPlayerPointTable.Size = new System.Drawing.Size(77, 16);
            this.FirstPlayerPointTable.TabIndex = 1;
            this.FirstPlayerPointTable.Text = "First Player:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(420, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 151);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(619, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 151);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // PointTableWinner
            // 
            this.PointTableWinner.AutoSize = true;
            this.PointTableWinner.Location = new System.Drawing.Point(170, 98);
            this.PointTableWinner.Name = "PointTableWinner";
            this.PointTableWinner.Size = new System.Drawing.Size(0, 16);
            this.PointTableWinner.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(834, 399);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GroupBox3PointTable);
            this.Controls.Add(this.groupBox2SecondPlayer);
            this.Controls.Add(this.groupBox1FirstPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1FirstPlayer.ResumeLayout(false);
            this.groupBox1FirstPlayer.PerformLayout();
            this.groupBox2SecondPlayer.ResumeLayout(false);
            this.groupBox2SecondPlayer.PerformLayout();
            this.GroupBox3PointTable.ResumeLayout(false);
            this.GroupBox3PointTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1FirstPlayer;
        private System.Windows.Forms.Button button1FirstPlayer;
        private System.Windows.Forms.Label TotalPointFirstPlayerValue;
        private System.Windows.Forms.Label TotalPointFirstPlayer;
        private System.Windows.Forms.Label Dice2FirstPlayerValue;
        private System.Windows.Forms.Label Dice2FirstPlayer;
        private System.Windows.Forms.Label Dice1FirstPlayerValue;
        private System.Windows.Forms.Label Dice1FirstPlayer;
        private System.Windows.Forms.GroupBox groupBox2SecondPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TotalPointSecondPlayerValue;
        private System.Windows.Forms.Label TotalPointSecondPlayer;
        private System.Windows.Forms.Label Dice2SecondPlayerValue;
        private System.Windows.Forms.Label Dice2SecondPlayer;
        private System.Windows.Forms.Label Dice1SecondPlayerValue;
        private System.Windows.Forms.Label Dice1SecondPlayer;
        private System.Windows.Forms.GroupBox GroupBox3PointTable;
        private System.Windows.Forms.Label SecondPlayerPointTableValue;
        private System.Windows.Forms.Label SecondPlayerPointTable;
        private System.Windows.Forms.Label FirstPlayerPointTableValue;
        private System.Windows.Forms.Label FirstPlayerPointTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label PointTableWinner;
    }
}

