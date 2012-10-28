namespace ruscehproj2
{
    partial class br004
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(br004));
            this.vkl = new System.Windows.Forms.Button();
            this.krist1 = new System.Windows.Forms.Button();
            this.krist2 = new System.Windows.Forms.Button();
            this.otkl = new System.Windows.Forms.Button();
            this.mode = new ruscehproj2.nPosSwitch();
            this.norm = new ruscehproj2.bulb();
            this.bad = new ruscehproj2.bulb();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
            this.amp = new ruscehproj2.Potenzhiomert();
            this.kanalN = new System.Windows.Forms.Label();
            this.kanal = new ruscehproj2.reg();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // vkl
            // 
            this.vkl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vkl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vkl.FlatAppearance.BorderSize = 0;
            this.vkl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vkl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vkl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vkl.Location = new System.Drawing.Point(424, 305);
            this.vkl.Name = "vkl";
            this.vkl.Size = new System.Drawing.Size(35, 30);
            this.vkl.TabIndex = 8;
            this.vkl.UseVisualStyleBackColor = false;
            this.vkl.Click += new System.EventHandler(this.vkl_Click);
            // 
            // krist1
            // 
            this.krist1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.krist1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krist1.FlatAppearance.BorderSize = 0;
            this.krist1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.krist1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.krist1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.krist1.Location = new System.Drawing.Point(396, 382);
            this.krist1.Name = "krist1";
            this.krist1.Size = new System.Drawing.Size(35, 30);
            this.krist1.TabIndex = 11;
            this.krist1.UseVisualStyleBackColor = false;
            this.krist1.Click += new System.EventHandler(this.krist1_Click);
            // 
            // krist2
            // 
            this.krist2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.krist2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.krist2.FlatAppearance.BorderSize = 0;
            this.krist2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.krist2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.krist2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.krist2.Location = new System.Drawing.Point(473, 382);
            this.krist2.Name = "krist2";
            this.krist2.Size = new System.Drawing.Size(35, 30);
            this.krist2.TabIndex = 12;
            this.krist2.UseVisualStyleBackColor = false;
            this.krist2.Click += new System.EventHandler(this.krist2_Click);
            // 
            // otkl
            // 
            this.otkl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.otkl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otkl.FlatAppearance.BorderSize = 0;
            this.otkl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.otkl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.otkl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otkl.Location = new System.Drawing.Point(473, 305);
            this.otkl.Name = "otkl";
            this.otkl.Size = new System.Drawing.Size(35, 30);
            this.otkl.TabIndex = 16;
            this.otkl.UseVisualStyleBackColor = false;
            this.otkl.Click += new System.EventHandler(this.otkl_Click);
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.Color.Transparent;
            this.mode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mode.BackgroundImage")));
            this.mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mode.Location = new System.Drawing.Point(244, 382);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(63, 74);
            this.mode.Step = 0;
            this.mode.TabIndex = 17;
            this.mode.Click += new System.EventHandler(this.mode_Click);
            // 
            // norm
            // 
            this.norm.BackColor = System.Drawing.Color.Transparent;
            this.norm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("norm.BackgroundImage")));
            this.norm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.norm.Location = new System.Drawing.Point(55, 62);
            this.norm.Name = "norm";
            this.norm.SetColor = "";
            this.norm.Size = new System.Drawing.Size(62, 62);
            this.norm.TabIndex = 18;
            // 
            // bad
            // 
            this.bad.BackColor = System.Drawing.Color.Transparent;
            this.bad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bad.BackgroundImage")));
            this.bad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bad.Location = new System.Drawing.Point(55, 174);
            this.bad.Name = "bad";
            this.bad.SetColor = "";
            this.bad.Size = new System.Drawing.Size(62, 62);
            this.bad.TabIndex = 19;
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(147, 99);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 20D;
            this.voltmetr1.Set_Center_str = "mA";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(271, 236);
            this.voltmetr1.TabIndex = 20;
            // 
            // amp
            // 
            this.amp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.amp.Location = new System.Drawing.Point(12, 621);
            this.amp.Name = "amp";
            this.amp.Set_Type = 0;
            this.amp.Set_Value = 50;
            this.amp.Size = new System.Drawing.Size(100, 85);
            this.amp.TabIndex = 21;
            this.amp.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.amp_Value_Changed);
            // 
            // kanalN
            // 
            this.kanalN.AutoSize = true;
            this.kanalN.BackColor = System.Drawing.Color.Transparent;
            this.kanalN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kanalN.ForeColor = System.Drawing.Color.Red;
            this.kanalN.Location = new System.Drawing.Point(388, 490);
            this.kanalN.Name = "kanalN";
            this.kanalN.Size = new System.Drawing.Size(23, 25);
            this.kanalN.TabIndex = 23;
            this.kanalN.Text = "1";
            // 
            // kanal
            // 
            this.kanal.BackColor = System.Drawing.Color.Transparent;
            this.kanal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.kanal.cap = 22;
            this.kanal.Location = new System.Drawing.Point(299, 516);
            this.kanal.Name = "kanal";
            this.kanal.Size = new System.Drawing.Size(203, 230);
            this.kanal.TabIndex = 24;
            this.kanal.Value_Changed += new ruscehproj2.reg.SomeEventDelegate(this.kanal_Value_Changed);
            // 
            // br004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ruscehproj2.Resources.br004;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 764);
            this.Controls.Add(this.kanal);
            this.Controls.Add(this.kanalN);
            this.Controls.Add(this.amp);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.bad);
            this.Controls.Add(this.norm);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.otkl);
            this.Controls.Add(this.krist2);
            this.Controls.Add(this.krist1);
            this.Controls.Add(this.vkl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "br004";
            this.Text = "БР-004";
            this.Load += new System.EventHandler(this.br004_Load);
            this.Controls.SetChildIndex(this.vkl, 0);
            this.Controls.SetChildIndex(this.krist1, 0);
            this.Controls.SetChildIndex(this.krist2, 0);
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.otkl, 0);
            this.Controls.SetChildIndex(this.mode, 0);
            this.Controls.SetChildIndex(this.norm, 0);
            this.Controls.SetChildIndex(this.bad, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.amp, 0);
            this.Controls.SetChildIndex(this.kanalN, 0);
            this.Controls.SetChildIndex(this.kanal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button vkl;
        public System.Windows.Forms.Button krist1;
        public System.Windows.Forms.Button krist2;
        public System.Windows.Forms.Button otkl;
        private nPosSwitch mode;
        private bulb norm;
        private bulb bad;
        private Potenzhiomert amp;
        private System.Windows.Forms.Label kanalN;
        private reg kanal;
        public Voltmetr voltmetr1;
    }
}