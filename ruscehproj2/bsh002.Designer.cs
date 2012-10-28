namespace ruscehproj2
{
    partial class bsh002
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bsh002));
            this.vkl = new System.Windows.Forms.Button();
            this.otkl = new System.Windows.Forms.Button();
            this.bulb1 = new ruscehproj2.bulb();
            this.vhodVU = new System.Windows.Forms.Button();
            this.vyhodVU = new System.Windows.Forms.Button();
            this.vyhDshDal = new System.Windows.Forms.Button();
            this.indikac = new System.Windows.Forms.Button();
            this.zapShaShd = new System.Windows.Forms.Button();
            this.pomehVyhod = new System.Windows.Forms.Button();
            this.voltageChk = new ruscehproj2.nPosSwitch();
            this.codes = new ruscehproj2.nPosSwitch();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
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
            this.vkl.Location = new System.Drawing.Point(268, 617);
            this.vkl.Name = "vkl";
            this.vkl.Size = new System.Drawing.Size(26, 30);
            this.vkl.TabIndex = 10;
            this.vkl.UseVisualStyleBackColor = false;
            this.vkl.Click += new System.EventHandler(this.vkl_Click);
            // 
            // otkl
            // 
            this.otkl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.otkl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otkl.FlatAppearance.BorderSize = 0;
            this.otkl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.otkl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.otkl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otkl.Location = new System.Drawing.Point(206, 617);
            this.otkl.Name = "otkl";
            this.otkl.Size = new System.Drawing.Size(26, 30);
            this.otkl.TabIndex = 11;
            this.otkl.UseVisualStyleBackColor = false;
            this.otkl.Click += new System.EventHandler(this.otkl_Click);
            // 
            // bulb1
            // 
            this.bulb1.BackColor = System.Drawing.Color.Transparent;
            this.bulb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulb1.BackgroundImage")));
            this.bulb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bulb1.Location = new System.Drawing.Point(223, 467);
            this.bulb1.Name = "bulb1";
            this.bulb1.SetColor = "";
            this.bulb1.Size = new System.Drawing.Size(56, 56);
            this.bulb1.TabIndex = 12;
            // 
            // vhodVU
            // 
            this.vhodVU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vhodVU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vhodVU.FlatAppearance.BorderSize = 0;
            this.vhodVU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vhodVU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vhodVU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vhodVU.Location = new System.Drawing.Point(28, 525);
            this.vhodVU.Name = "vhodVU";
            this.vhodVU.Size = new System.Drawing.Size(90, 15);
            this.vhodVU.TabIndex = 151;
            this.vhodVU.UseVisualStyleBackColor = false;
            this.vhodVU.Click += new System.EventHandler(this.vhodVU_Click);
            // 
            // vyhodVU
            // 
            this.vyhodVU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vyhodVU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vyhodVU.FlatAppearance.BorderSize = 0;
            this.vyhodVU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vyhodVU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vyhodVU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vyhodVU.Location = new System.Drawing.Point(28, 541);
            this.vyhodVU.Name = "vyhodVU";
            this.vyhodVU.Size = new System.Drawing.Size(90, 15);
            this.vyhodVU.TabIndex = 152;
            this.vyhodVU.UseVisualStyleBackColor = false;
            this.vyhodVU.Click += new System.EventHandler(this.vyhodVU_Click);
            // 
            // vyhDshDal
            // 
            this.vyhDshDal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vyhDshDal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vyhDshDal.FlatAppearance.BorderSize = 0;
            this.vyhDshDal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vyhDshDal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vyhDshDal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vyhDshDal.Location = new System.Drawing.Point(393, 525);
            this.vyhDshDal.Name = "vyhDshDal";
            this.vyhDshDal.Size = new System.Drawing.Size(90, 15);
            this.vyhDshDal.TabIndex = 153;
            this.vyhDshDal.UseVisualStyleBackColor = false;
            this.vyhDshDal.Click += new System.EventHandler(this.vyhDshDal_Click);
            // 
            // indikac
            // 
            this.indikac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.indikac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.indikac.FlatAppearance.BorderSize = 0;
            this.indikac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.indikac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.indikac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indikac.Location = new System.Drawing.Point(393, 541);
            this.indikac.Name = "indikac";
            this.indikac.Size = new System.Drawing.Size(90, 15);
            this.indikac.TabIndex = 154;
            this.indikac.UseVisualStyleBackColor = false;
            this.indikac.Click += new System.EventHandler(this.indikac_Click);
            // 
            // zapShaShd
            // 
            this.zapShaShd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.zapShaShd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zapShaShd.FlatAppearance.BorderSize = 0;
            this.zapShaShd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.zapShaShd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.zapShaShd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapShaShd.Location = new System.Drawing.Point(364, 559);
            this.zapShaShd.Name = "zapShaShd";
            this.zapShaShd.Size = new System.Drawing.Size(113, 16);
            this.zapShaShd.TabIndex = 155;
            this.zapShaShd.UseVisualStyleBackColor = false;
            this.zapShaShd.Click += new System.EventHandler(this.zapShaShd_Click);
            // 
            // pomehVyhod
            // 
            this.pomehVyhod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.pomehVyhod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pomehVyhod.FlatAppearance.BorderSize = 0;
            this.pomehVyhod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.pomehVyhod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.pomehVyhod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pomehVyhod.Location = new System.Drawing.Point(364, 575);
            this.pomehVyhod.Name = "pomehVyhod";
            this.pomehVyhod.Size = new System.Drawing.Size(113, 16);
            this.pomehVyhod.TabIndex = 156;
            this.pomehVyhod.UseVisualStyleBackColor = false;
            this.pomehVyhod.Click += new System.EventHandler(this.pomehVyhod_Click);
            // 
            // voltageChk
            // 
            this.voltageChk.BackColor = System.Drawing.Color.Transparent;
            this.voltageChk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltageChk.BackgroundImage")));
            this.voltageChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltageChk.Location = new System.Drawing.Point(223, 372);
            this.voltageChk.Name = "voltageChk";
            this.voltageChk.Size = new System.Drawing.Size(55, 55);
            this.voltageChk.Step = 0;
            this.voltageChk.TabIndex = 157;
            this.voltageChk.Click += new System.EventHandler(this.voltageChk_Click);
            // 
            // codes
            // 
            this.codes.BackColor = System.Drawing.Color.Transparent;
            this.codes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("codes.BackgroundImage")));
            this.codes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.codes.Location = new System.Drawing.Point(387, 371);
            this.codes.Name = "codes";
            this.codes.Size = new System.Drawing.Size(55, 55);
            this.codes.Step = 0;
            this.codes.TabIndex = 158;
            this.codes.Click += new System.EventHandler(this.codes_Click);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(169, 145);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 60D;
            this.voltmetr1.Set_Center_str = "V";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(166, 166);
            this.voltmetr1.TabIndex = 159;
            // 
            // bsh002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(508, 719);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.codes);
            this.Controls.Add(this.voltageChk);
            this.Controls.Add(this.pomehVyhod);
            this.Controls.Add(this.zapShaShd);
            this.Controls.Add(this.indikac);
            this.Controls.Add(this.vyhDshDal);
            this.Controls.Add(this.vyhodVU);
            this.Controls.Add(this.vhodVU);
            this.Controls.Add(this.bulb1);
            this.Controls.Add(this.otkl);
            this.Controls.Add(this.vkl);
            this.DoubleBuffered = true;
            this.Name = "bsh002";
            this.Text = "БШ-002";
            this.Controls.SetChildIndex(this.vkl, 0);
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.otkl, 0);
            this.Controls.SetChildIndex(this.bulb1, 0);
            this.Controls.SetChildIndex(this.vhodVU, 0);
            this.Controls.SetChildIndex(this.vyhodVU, 0);
            this.Controls.SetChildIndex(this.vyhDshDal, 0);
            this.Controls.SetChildIndex(this.indikac, 0);
            this.Controls.SetChildIndex(this.zapShaShd, 0);
            this.Controls.SetChildIndex(this.pomehVyhod, 0);
            this.Controls.SetChildIndex(this.voltageChk, 0);
            this.Controls.SetChildIndex(this.codes, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button vkl;
        public System.Windows.Forms.Button otkl;
        private bulb bulb1;
        private System.Windows.Forms.Button vhodVU;
        private System.Windows.Forms.Button vyhodVU;
        private System.Windows.Forms.Button vyhDshDal;
        private System.Windows.Forms.Button indikac;
        private System.Windows.Forms.Button zapShaShd;
        private System.Windows.Forms.Button pomehVyhod;
        private nPosSwitch voltageChk;
        private nPosSwitch codes;
        private Voltmetr voltmetr1;
    }
}