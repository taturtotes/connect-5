namespace connect5
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.sizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.check76 = new System.Windows.Forms.CheckBox();
            this.check97 = new System.Windows.Forms.CheckBox();
            this.check107 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.Location = new System.Drawing.Point(14, 207);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(203, 40);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "Board Size:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Limit:";
            // 
            // check76
            // 
            this.check76.AutoSize = true;
            this.check76.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check76.Location = new System.Drawing.Point(219, 214);
            this.check76.Name = "check76";
            this.check76.Size = new System.Drawing.Size(88, 33);
            this.check76.TabIndex = 3;
            this.check76.Text = "7 x 6";
            this.check76.UseVisualStyleBackColor = true;
            // 
            // check97
            // 
            this.check97.AutoSize = true;
            this.check97.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check97.Location = new System.Drawing.Point(340, 214);
            this.check97.Name = "check97";
            this.check97.Size = new System.Drawing.Size(88, 33);
            this.check97.TabIndex = 4;
            this.check97.Text = "9 x 7";
            this.check97.UseVisualStyleBackColor = true;
            // 
            // check107
            // 
            this.check107.AutoSize = true;
            this.check107.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check107.Location = new System.Drawing.Point(473, 214);
            this.check107.Name = "check107";
            this.check107.Size = new System.Drawing.Size(101, 33);
            this.check107.TabIndex = 5;
            this.check107.Text = "10 x 7";
            this.check107.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(219, 278);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(96, 33);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "5 sec";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(324, 278);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(109, 33);
            this.checkBox10.TabIndex = 7;
            this.checkBox10.Text = "10 sec";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox15.Location = new System.Drawing.Point(468, 278);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(109, 33);
            this.checkBox15.TabIndex = 8;
            this.checkBox15.Text = "15 sec";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(219, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Play!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::connect5.Properties.Resources.connect4logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(79, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 152);
            this.panel1.TabIndex = 0;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 380);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox15);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.check107);
            this.Controls.Add(this.check97);
            this.Controls.Add(this.check76);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check76;
        private System.Windows.Forms.CheckBox check97;
        private System.Windows.Forms.CheckBox check107;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.Button button1;
    }
}