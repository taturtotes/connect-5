namespace connect5
{
    partial class board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(board));
            this.board1 = new System.Windows.Forms.TableLayoutPanel();
            this.redPanel = new System.Windows.Forms.Panel();
            this.RedLabel = new System.Windows.Forms.Label();
            this.ComputerButton1 = new System.Windows.Forms.Button();
            this.HumanButtonRed = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.YellowLabel = new System.Windows.Forms.Label();
            this.ComputerButton2 = new System.Windows.Forms.Button();
            this.HumanButton2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.turnPanel = new System.Windows.Forms.Panel();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.ControlLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.redPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // board1
            // 
            this.board1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.board1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.board1.ColumnCount = 6;
            this.board1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.board1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.board1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.board1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.board1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.board1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.board1.Location = new System.Drawing.Point(358, 18);
            this.board1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.board1.Name = "board1";
            this.board1.RowCount = 7;
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.Size = new System.Drawing.Size(662, 536);
            this.board1.TabIndex = 0;
            this.board1.Click += new System.EventHandler(this.board1_Click);
            // 
            // redPanel
            // 
            this.redPanel.BackColor = System.Drawing.Color.IndianRed;
            this.redPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.redPanel.Controls.Add(this.RedLabel);
            this.redPanel.Controls.Add(this.ComputerButton1);
            this.redPanel.Controls.Add(this.HumanButtonRed);
            this.redPanel.Location = new System.Drawing.Point(11, 47);
            this.redPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(264, 140);
            this.redPanel.TabIndex = 3;
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.BackColor = System.Drawing.Color.White;
            this.RedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLabel.ForeColor = System.Drawing.Color.Red;
            this.RedLabel.Location = new System.Drawing.Point(7, 7);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(58, 29);
            this.RedLabel.TabIndex = 2;
            this.RedLabel.Text = "Red";
            // 
            // ComputerButton1
            // 
            this.ComputerButton1.BackColor = System.Drawing.Color.White;
            this.ComputerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComputerButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerButton1.ForeColor = System.Drawing.Color.Red;
            this.ComputerButton1.Location = new System.Drawing.Point(140, 55);
            this.ComputerButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComputerButton1.Name = "ComputerButton1";
            this.ComputerButton1.Size = new System.Drawing.Size(109, 46);
            this.ComputerButton1.TabIndex = 1;
            this.ComputerButton1.Text = "Computer";
            this.ComputerButton1.UseVisualStyleBackColor = false;
            this.ComputerButton1.Click += new System.EventHandler(this.ComputerButton1_Click);
            // 
            // HumanButtonRed
            // 
            this.HumanButtonRed.BackColor = System.Drawing.Color.White;
            this.HumanButtonRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HumanButtonRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanButtonRed.ForeColor = System.Drawing.Color.Red;
            this.HumanButtonRed.Location = new System.Drawing.Point(12, 53);
            this.HumanButtonRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HumanButtonRed.Name = "HumanButtonRed";
            this.HumanButtonRed.Size = new System.Drawing.Size(108, 48);
            this.HumanButtonRed.TabIndex = 0;
            this.HumanButtonRed.Text = "Human";
            this.HumanButtonRed.UseVisualStyleBackColor = false;
            this.HumanButtonRed.Click += new System.EventHandler(this.HumanButtonRed_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.YellowLabel);
            this.panel1.Controls.Add(this.ComputerButton2);
            this.panel1.Controls.Add(this.HumanButton2);
            this.panel1.Location = new System.Drawing.Point(11, 192);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 140);
            this.panel1.TabIndex = 4;
            // 
            // YellowLabel
            // 
            this.YellowLabel.AutoSize = true;
            this.YellowLabel.BackColor = System.Drawing.Color.White;
            this.YellowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.YellowLabel.Location = new System.Drawing.Point(7, 14);
            this.YellowLabel.Name = "YellowLabel";
            this.YellowLabel.Size = new System.Drawing.Size(87, 29);
            this.YellowLabel.TabIndex = 3;
            this.YellowLabel.Text = "Yellow";
            // 
            // ComputerButton2
            // 
            this.ComputerButton2.BackColor = System.Drawing.Color.White;
            this.ComputerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComputerButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerButton2.ForeColor = System.Drawing.Color.Goldenrod;
            this.ComputerButton2.Location = new System.Drawing.Point(140, 54);
            this.ComputerButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComputerButton2.Name = "ComputerButton2";
            this.ComputerButton2.Size = new System.Drawing.Size(109, 46);
            this.ComputerButton2.TabIndex = 2;
            this.ComputerButton2.Text = "Computer";
            this.ComputerButton2.UseVisualStyleBackColor = false;
            this.ComputerButton2.Click += new System.EventHandler(this.ComputerButton2_Click);
            // 
            // HumanButton2
            // 
            this.HumanButton2.BackColor = System.Drawing.Color.White;
            this.HumanButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HumanButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanButton2.ForeColor = System.Drawing.Color.Goldenrod;
            this.HumanButton2.Location = new System.Drawing.Point(13, 54);
            this.HumanButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HumanButton2.Name = "HumanButton2";
            this.HumanButton2.Size = new System.Drawing.Size(107, 46);
            this.HumanButton2.TabIndex = 1;
            this.HumanButton2.Text = "Human";
            this.HumanButton2.UseVisualStyleBackColor = false;
            this.HumanButton2.Click += new System.EventHandler(this.HumanButton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.logButton);
            this.panel2.Controls.Add(this.turnPanel);
            this.panel2.Controls.Add(this.TurnLabel);
            this.panel2.Controls.Add(this.ControlLabel);
            this.panel2.Controls.Add(this.ResetButton);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Location = new System.Drawing.Point(11, 359);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 196);
            this.panel2.TabIndex = 5;
            // 
            // turnPanel
            // 
            this.turnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turnPanel.Location = new System.Drawing.Point(132, 98);
            this.turnPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.turnPanel.Name = "turnPanel";
            this.turnPanel.Size = new System.Drawing.Size(119, 84);
            this.turnPanel.TabIndex = 4;
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.BackColor = System.Drawing.Color.White;
            this.TurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnLabel.ForeColor = System.Drawing.Color.Blue;
            this.TurnLabel.Location = new System.Drawing.Point(9, 98);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(120, 24);
            this.TurnLabel.TabIndex = 3;
            this.TurnLabel.Text = "Whose Turn:";
            // 
            // ControlLabel
            // 
            this.ControlLabel.AutoSize = true;
            this.ControlLabel.BackColor = System.Drawing.Color.White;
            this.ControlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlLabel.ForeColor = System.Drawing.Color.Blue;
            this.ControlLabel.Location = new System.Drawing.Point(7, 7);
            this.ControlLabel.Name = "ControlLabel";
            this.ControlLabel.Size = new System.Drawing.Size(91, 29);
            this.ControlLabel.TabIndex = 2;
            this.ControlLabel.Text = "Control";
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.White;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.Blue;
            this.ResetButton.Location = new System.Drawing.Point(132, 42);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(117, 34);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset Game";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Blue;
            this.startButton.Location = new System.Drawing.Point(13, 42);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(108, 34);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // logButton
            // 
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.ForeColor = System.Drawing.Color.Blue;
            this.logButton.Location = new System.Drawing.Point(14, 140);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(107, 42);
            this.logButton.TabIndex = 5;
            this.logButton.Text = "Check Log";
            this.logButton.UseVisualStyleBackColor = true;
            // 
            // board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1031, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.redPanel);
            this.Controls.Add(this.board1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "board";
            this.Text = "Connect 5";
            this.redPanel.ResumeLayout(false);
            this.redPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel board1;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.Button ComputerButton1;
        private System.Windows.Forms.Button HumanButtonRed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ComputerButton2;
        private System.Windows.Forms.Button HumanButton2;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label YellowLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel turnPanel;
        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Label ControlLabel;
        private System.Windows.Forms.Button startButton;
        public System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button logButton;
    }
}

