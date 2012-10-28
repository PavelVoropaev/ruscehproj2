namespace ruscehproj2
{
    partial class bp119
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bp119));
            this.button1 = new System.Windows.Forms.Button();
            this.pwr = new ruscehproj2.tumbler();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
            this.bulb1 = new ruscehproj2.bulb();
            this.voltageChk = new ruscehproj2.tumbler();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(124)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(124)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(124)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(124)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(86, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 45);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pwr
            // 
            this.pwr.BackColor = System.Drawing.Color.Transparent;
            this.pwr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pwr.BackgroundImage")));
            this.pwr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pwr.isSided = false;
            this.pwr.Location = new System.Drawing.Point(294, 283);
            this.pwr.Name = "pwr";
            this.pwr.Set_Skin = 2;
            this.pwr.Size = new System.Drawing.Size(55, 121);
            this.pwr.State = false;
            this.pwr.TabIndex = 2;
            this.pwr.Click += new System.EventHandler(this.pwr_Click);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(47, 211);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 60D;
            this.voltmetr1.Set_Center_str = "V";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(117, 118);
            this.voltmetr1.TabIndex = 15;
            // 
            // bulb1
            // 
            this.bulb1.BackColor = System.Drawing.Color.Transparent;
            this.bulb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulb1.BackgroundImage")));
            this.bulb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bulb1.Location = new System.Drawing.Point(309, 77);
            this.bulb1.Name = "bulb1";
            this.bulb1.SetColor = "";
            this.bulb1.Size = new System.Drawing.Size(42, 42);
            this.bulb1.TabIndex = 16;
            // 
            // voltageChk
            // 
            this.voltageChk.BackColor = System.Drawing.Color.Transparent;
            this.voltageChk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltageChk.BackgroundImage")));
            this.voltageChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltageChk.isSided = false;
            this.voltageChk.Location = new System.Drawing.Point(92, 374);
            this.voltageChk.Name = "voltageChk";
            this.voltageChk.Set_Skin = 1;
            this.voltageChk.Size = new System.Drawing.Size(32, 32);
            this.voltageChk.State = false;
            this.voltageChk.TabIndex = 17;
            this.voltageChk.Click += new System.EventHandler(this.tumbler1_Click);
            // 
            // bp119
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(488, 677);
            this.Controls.Add(this.voltageChk);
            this.Controls.Add(this.bulb1);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.pwr);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bp119";
            this.Text = "БП-119";
            this.Load += new System.EventHandler(this.bp119_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.pwr, 0);
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.bulb1, 0);
            this.Controls.SetChildIndex(this.voltageChk, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public tumbler pwr;
        private Voltmetr voltmetr1;
        private bulb bulb1;
        private tumbler voltageChk;
    }
}