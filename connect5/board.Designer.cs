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
            this.board1 = new System.Windows.Forms.TableLayoutPanel();
            this.redPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HumanButtonRed = new System.Windows.Forms.Button();
            this.ComputerButton1 = new System.Windows.Forms.Button();
            this.HumanButton2 = new System.Windows.Forms.Button();
            this.ComputerButton2 = new System.Windows.Forms.Button();
            this.RedLabel = new System.Windows.Forms.Label();
            this.YellowLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ControlLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.turnPanel = new System.Windows.Forms.Panel();
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
            this.board1.Location = new System.Drawing.Point(403, 23);
            this.board1.Name = "board1";
            this.board1.RowCount = 7;
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.board1.Size = new System.Drawing.Size(745, 670);
            this.board1.TabIndex = 0;
            this.board1.Click += new System.EventHandler(this.board1_Click);
            // 
            // redPanel
            // 
            this.redPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redPanel.Controls.Add(this.RedLabel);
            this.redPanel.Controls.Add(this.ComputerButton1);
            this.redPanel.Controls.Add(this.HumanButtonRed);
            this.redPanel.Location = new System.Drawing.Point(12, 59);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(297, 175);
            this.redPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.YellowLabel);
            this.panel1.Controls.Add(this.ComputerButton2);
            this.panel1.Controls.Add(this.HumanButton2);
            this.panel1.Location = new System.Drawing.Point(12, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 175);
            this.panel1.TabIndex = 4;
            // 
            // HumanButtonRed
            // 
            this.HumanButtonRed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HumanButtonRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanButtonRed.Location = new System.Drawing.Point(14, 66);
            this.HumanButtonRed.Name = "HumanButtonRed";
            this.HumanButtonRed.Size = new System.Drawing.Size(121, 60);
            this.HumanButtonRed.TabIndex = 0;
            this.HumanButtonRed.Text = "Human";
            this.HumanButtonRed.UseVisualStyleBackColor = true;
            this.HumanButtonRed.Click += new System.EventHandler(this.HumanButtonRed_Click);
            // 
            // ComputerButton1
            // 
            this.ComputerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComputerButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerButton1.Location = new System.Drawing.Point(157, 69);
            this.ComputerButton1.Name = "ComputerButton1";
            this.ComputerButton1.Size = new System.Drawing.Size(123, 57);
            this.ComputerButton1.TabIndex = 1;
            this.ComputerButton1.Text = "Computer";
            this.ComputerButton1.UseVisualStyleBackColor = true;
            // 
            // HumanButton2
            // 
            this.HumanButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HumanButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HumanButton2.Location = new System.Drawing.Point(15, 67);
            this.HumanButton2.Name = "HumanButton2";
            this.HumanButton2.Size = new System.Drawing.Size(120, 57);
            this.HumanButton2.TabIndex = 1;
            this.HumanButton2.Text = "Human";
            this.HumanButton2.UseVisualStyleBackColor = true;
            this.HumanButton2.Click += new System.EventHandler(this.HumanButton2_Click);
            // 
            // ComputerButton2
            // 
            this.ComputerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComputerButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerButton2.Location = new System.Drawing.Point(157, 67);
            this.ComputerButton2.Name = "ComputerButton2";
            this.ComputerButton2.Size = new System.Drawing.Size(123, 57);
            this.ComputerButton2.TabIndex = 2;
            this.ComputerButton2.Text = "Computer";
            this.ComputerButton2.UseVisualStyleBackColor = true;
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedLabel.ForeColor = System.Drawing.Color.Red;
            this.RedLabel.Location = new System.Drawing.Point(8, 9);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(66, 32);
            this.RedLabel.TabIndex = 2;
            this.RedLabel.Text = "Red";
            // 
            // YellowLabel
            // 
            this.YellowLabel.AutoSize = true;
            this.YellowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YellowLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.YellowLabel.Location = new System.Drawing.Point(8, 17);
            this.YellowLabel.Name = "YellowLabel";
            this.YellowLabel.Size = new System.Drawing.Size(119, 38);
            this.YellowLabel.TabIndex = 3;
            this.YellowLabel.Text = "Yellow";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.turnPanel);
            this.panel2.Controls.Add(this.TurnLabel);
            this.panel2.Controls.Add(this.ControlLabel);
            this.panel2.Controls.Add(this.ResetButton);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Location = new System.Drawing.Point(12, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 244);
            this.panel2.TabIndex = 5;
            // 
            // ControlLabel
            // 
            this.ControlLabel.AutoSize = true;
            this.ControlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlLabel.ForeColor = System.Drawing.Color.Blue;
            this.ControlLabel.Location = new System.Drawing.Point(8, 9);
            this.ControlLabel.Name = "ControlLabel";
            this.ControlLabel.Size = new System.Drawing.Size(127, 38);
            this.ControlLabel.TabIndex = 2;
            this.ControlLabel.Text = "Control";
            // 
            // ResetButton
            // 
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(148, 53);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(132, 43);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset Game";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(15, 53);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(121, 43);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // TurnLabel
            // 
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnLabel.Location = new System.Drawing.Point(10, 123);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(162, 31);
            this.TurnLabel.TabIndex = 3;
            this.TurnLabel.Text = "Whose Turn:";
            // 
            // turnPanel
            // 
            this.turnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turnPanel.Location = new System.Drawing.Point(148, 123);
            this.turnPanel.Name = "turnPanel";
            this.turnPanel.Size = new System.Drawing.Size(134, 104);
            this.turnPanel.TabIndex = 4;
            // 
            // board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 723);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.redPanel);
            this.Controls.Add(this.board1);
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
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button startButton;
    }
}

