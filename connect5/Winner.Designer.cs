namespace connect5
{
    partial class Winner
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
            this.winnerLabel = new System.Windows.Forms.Label();
            this.winnerPlayer = new System.Windows.Forms.Panel();
            this.againButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(85, 9);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(297, 69);
            this.winnerLabel.TabIndex = 0;
            this.winnerLabel.Text = "WINNER!";
            // 
            // winnerPlayer
            // 
            this.winnerPlayer.Location = new System.Drawing.Point(176, 93);
            this.winnerPlayer.Name = "winnerPlayer";
            this.winnerPlayer.Size = new System.Drawing.Size(100, 84);
            this.winnerPlayer.TabIndex = 1;
            // 
            // againButton
            // 
            this.againButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.againButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.againButton.Location = new System.Drawing.Point(261, 197);
            this.againButton.Name = "againButton";
            this.againButton.Size = new System.Drawing.Size(196, 83);
            this.againButton.TabIndex = 2;
            this.againButton.Text = "Play Again?";
            this.againButton.UseVisualStyleBackColor = false;
            this.againButton.Click += new System.EventHandler(this.againButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 197);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 83);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 309);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.againButton);
            this.Controls.Add(this.winnerPlayer);
            this.Controls.Add(this.winnerLabel);
            this.Name = "Winner";
            this.Text = "Winner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Panel winnerPlayer;
        private System.Windows.Forms.Button againButton;
        private System.Windows.Forms.Button exitButton;
    }
}