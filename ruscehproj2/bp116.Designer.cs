namespace ruscehproj2
{
    partial class bp116
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bp116));
            this.mode = new ruscehproj2.nPosSwitch();
            this.mode2 = new ruscehproj2.nPosSwitch();
            this.bulb1 = new ruscehproj2.bulb();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
            this.voltmetr2 = new ruscehproj2.Voltmetr();
            this.voltmetr3 = new ruscehproj2.Voltmetr();
            this.voltmetr4 = new ruscehproj2.Voltmetr();
            this.voltmetr5 = new ruscehproj2.Voltmetr();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.Color.Transparent;
            this.mode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mode.BackgroundImage")));
            this.mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mode.Location = new System.Drawing.Point(204, 179);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(49, 63);
            this.mode.Step = 0;
            this.mode.TabIndex = 15;
            this.mode.Click += new System.EventHandler(this.mode_Click);
            // 
            // mode2
            // 
            this.mode2.BackColor = System.Drawing.Color.Transparent;
            this.mode2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mode2.BackgroundImage")));
            this.mode2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mode2.Location = new System.Drawing.Point(95, 503);
            this.mode2.Name = "mode2";
            this.mode2.Size = new System.Drawing.Size(46, 56);
            this.mode2.Step = 0;
            this.mode2.TabIndex = 15;
            this.mode2.Click += new System.EventHandler(this.mode2_Click);
            // 
            // bulb1
            // 
            this.bulb1.BackColor = System.Drawing.Color.Transparent;
            this.bulb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulb1.BackgroundImage")));
            this.bulb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bulb1.Location = new System.Drawing.Point(81, 418);
            this.bulb1.Name = "bulb1";
            this.bulb1.SetColor = "";
            this.bulb1.Size = new System.Drawing.Size(27, 24);
            this.bulb1.TabIndex = 16;
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(283, 141);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 60D;
            this.voltmetr1.Set_Center_str = "V";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(64, 62);
            this.voltmetr1.TabIndex = 14;
            this.voltmetr1.Click += new System.EventHandler(this.voltmetr1_Click);
            // 
            // voltmetr2
            // 
            this.voltmetr2.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr2.BackgroundImage")));
            this.voltmetr2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr2.current_Value = 0;
            this.voltmetr2.Location = new System.Drawing.Point(111, 90);
            this.voltmetr2.Name = "voltmetr2";
            this.voltmetr2.Set_Bar_min = 0;
            this.voltmetr2.Set_Bar_N_bolt = 10;
            this.voltmetr2.Set_Bar_N_not_bolt = 50;
            this.voltmetr2.Set_Bar_N_tzhifra = 10;
            this.voltmetr2.Set_Bar_step = 60D;
            this.voltmetr2.Set_Center_str = "V";
            this.voltmetr2.Set_Value = 0;
            this.voltmetr2.Size = new System.Drawing.Size(68, 63);
            this.voltmetr2.TabIndex = 14;
            // 
            // voltmetr3
            // 
            this.voltmetr3.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr3.BackgroundImage")));
            this.voltmetr3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr3.current_Value = 0;
            this.voltmetr3.Location = new System.Drawing.Point(283, 67);
            this.voltmetr3.Name = "voltmetr3";
            this.voltmetr3.Set_Bar_min = 0;
            this.voltmetr3.Set_Bar_N_bolt = 10;
            this.voltmetr3.Set_Bar_N_not_bolt = 50;
            this.voltmetr3.Set_Bar_N_tzhifra = 10;
            this.voltmetr3.Set_Bar_step = 60D;
            this.voltmetr3.Set_Center_str = "V";
            this.voltmetr3.Set_Value = 0;
            this.voltmetr3.Size = new System.Drawing.Size(64, 68);
            this.voltmetr3.TabIndex = 14;
            // 
            // voltmetr4
            // 
            this.voltmetr4.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr4.BackgroundImage")));
            this.voltmetr4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr4.current_Value = 0;
            this.voltmetr4.Location = new System.Drawing.Point(290, 474);
            this.voltmetr4.Name = "voltmetr4";
            this.voltmetr4.Set_Bar_min = 0;
            this.voltmetr4.Set_Bar_N_bolt = 10;
            this.voltmetr4.Set_Bar_N_not_bolt = 50;
            this.voltmetr4.Set_Bar_N_tzhifra = 10;
            this.voltmetr4.Set_Bar_step = 60D;
            this.voltmetr4.Set_Center_str = "V";
            this.voltmetr4.Set_Value = 0;
            this.voltmetr4.Size = new System.Drawing.Size(64, 68);
            this.voltmetr4.TabIndex = 14;
            // 
            // voltmetr5
            // 
            this.voltmetr5.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr5.BackgroundImage")));
            this.voltmetr5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr5.current_Value = 0;
            this.voltmetr5.Location = new System.Drawing.Point(290, 548);
            this.voltmetr5.Name = "voltmetr5";
            this.voltmetr5.Set_Bar_min = 0;
            this.voltmetr5.Set_Bar_N_bolt = 10;
            this.voltmetr5.Set_Bar_N_not_bolt = 50;
            this.voltmetr5.Set_Bar_N_tzhifra = 10;
            this.voltmetr5.Set_Bar_step = 60D;
            this.voltmetr5.Set_Center_str = "V";
            this.voltmetr5.Set_Value = 0;
            this.voltmetr5.Size = new System.Drawing.Size(64, 62);
            this.voltmetr5.TabIndex = 14;
            this.voltmetr5.Click += new System.EventHandler(this.voltmetr5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(79, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(117, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(154, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(117, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(225, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(262, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(225, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(187, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "1";
            // 
            // bp116
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ruscehproj2.Resources.bp116;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(464, 756);
            this.Controls.Add(this.bulb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mode2);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.voltmetr3);
            this.Controls.Add(this.voltmetr4);
            this.Controls.Add(this.voltmetr2);
            this.Controls.Add(this.voltmetr5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bp116";
            this.Text = "БП-116";
            this.Load += new System.EventHandler(this.bp116_Load);
            this.Click += new System.EventHandler(this.bp116_Click);
            this.Controls.SetChildIndex(this.voltmetr5, 0);
            this.Controls.SetChildIndex(this.voltmetr2, 0);
            this.Controls.SetChildIndex(this.voltmetr4, 0);
            this.Controls.SetChildIndex(this.voltmetr3, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.mode2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.mode, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.bulb1, 0);
            this.Controls.SetChildIndex(this.str, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private nPosSwitch mode;
        private nPosSwitch mode2;
        public bulb bulb1;
        private Voltmetr voltmetr2;
        private Voltmetr voltmetr3;
        private Voltmetr voltmetr4;
        public Voltmetr voltmetr1;
        public Voltmetr voltmetr5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    
    }
}