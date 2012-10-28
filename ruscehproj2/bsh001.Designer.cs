namespace ruscehproj2
{
    partial class bsh001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bsh001));
            this.vkl = new System.Windows.Forms.Button();
            this.otkl = new System.Windows.Forms.Button();
            this.bulb1 = new ruscehproj2.bulb();
            this.regZad = new ruscehproj2.nPosSwitch();
            this.msek = new ruscehproj2.nPosSwitch();
            this.imitator = new ruscehproj2.nPosSwitch();
            this.voltageContr = new ruscehproj2.nPosSwitch();
            this.codes = new ruscehproj2.nPosSwitch();
            this.vhod03 = new System.Windows.Forms.Button();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
            this.voltage = new ruscehproj2.Potenzhiomert();
            this.eject = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.regNach = new ruscehproj2.Potenzhiomert();
            this.vhodD = new System.Windows.Forms.Button();
            this.vyhodImit = new System.Windows.Forms.Button();
            this.kalibr = new ruscehproj2.Potenzhiomert();
            this.izmer = new System.Windows.Forms.Button();
            this.generator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.vkl.Location = new System.Drawing.Point(254, 562);
            this.vkl.Name = "vkl";
            this.vkl.Size = new System.Drawing.Size(32, 27);
            this.vkl.TabIndex = 7;
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
            this.otkl.Location = new System.Drawing.Point(194, 562);
            this.otkl.Name = "otkl";
            this.otkl.Size = new System.Drawing.Size(32, 27);
            this.otkl.TabIndex = 8;
            this.otkl.UseVisualStyleBackColor = false;
            this.otkl.Click += new System.EventHandler(this.otkl_Click);
            // 
            // bulb1
            // 
            this.bulb1.BackColor = System.Drawing.Color.Transparent;
            this.bulb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulb1.BackgroundImage")));
            this.bulb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bulb1.Location = new System.Drawing.Point(219, 431);
            this.bulb1.Name = "bulb1";
            this.bulb1.SetColor = "";
            this.bulb1.Size = new System.Drawing.Size(42, 43);
            this.bulb1.TabIndex = 9;
            // 
            // regZad
            // 
            this.regZad.BackColor = System.Drawing.Color.Transparent;
            this.regZad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regZad.BackgroundImage")));
            this.regZad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.regZad.Location = new System.Drawing.Point(359, 100);
            this.regZad.Name = "regZad";
            this.regZad.Size = new System.Drawing.Size(60, 60);
            this.regZad.Step = 0;
            this.regZad.TabIndex = 10;
            this.regZad.Click += new System.EventHandler(this.regZad_Click);
            // 
            // msek
            // 
            this.msek.BackColor = System.Drawing.Color.Transparent;
            this.msek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("msek.BackgroundImage")));
            this.msek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.msek.Location = new System.Drawing.Point(361, 218);
            this.msek.Name = "msek";
            this.msek.Size = new System.Drawing.Size(60, 60);
            this.msek.Step = 0;
            this.msek.TabIndex = 11;
            this.msek.Click += new System.EventHandler(this.msek_Click);
            // 
            // imitator
            // 
            this.imitator.BackColor = System.Drawing.Color.Transparent;
            this.imitator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imitator.BackgroundImage")));
            this.imitator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imitator.Location = new System.Drawing.Point(57, 219);
            this.imitator.Name = "imitator";
            this.imitator.Size = new System.Drawing.Size(57, 67);
            this.imitator.Step = 0;
            this.imitator.TabIndex = 12;
            this.imitator.Click += new System.EventHandler(this.imitator_Click);
            // 
            // voltageContr
            // 
            this.voltageContr.BackColor = System.Drawing.Color.Transparent;
            this.voltageContr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltageContr.BackgroundImage")));
            this.voltageContr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltageContr.Location = new System.Drawing.Point(208, 336);
            this.voltageContr.Name = "voltageContr";
            this.voltageContr.Size = new System.Drawing.Size(60, 62);
            this.voltageContr.Step = 0;
            this.voltageContr.TabIndex = 13;
            this.voltageContr.Click += new System.EventHandler(this.voltageContr_Click);
            // 
            // codes
            // 
            this.codes.BackColor = System.Drawing.Color.Transparent;
            this.codes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("codes.BackgroundImage")));
            this.codes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.codes.Location = new System.Drawing.Point(364, 335);
            this.codes.Name = "codes";
            this.codes.Size = new System.Drawing.Size(60, 62);
            this.codes.Step = 0;
            this.codes.TabIndex = 14;
            // 
            // vhod03
            // 
            this.vhod03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vhod03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vhod03.FlatAppearance.BorderSize = 0;
            this.vhod03.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vhod03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vhod03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vhod03.Location = new System.Drawing.Point(38, 474);
            this.vhod03.Name = "vhod03";
            this.vhod03.Size = new System.Drawing.Size(90, 15);
            this.vhod03.TabIndex = 152;
            this.vhod03.UseVisualStyleBackColor = false;
            this.vhod03.Click += new System.EventHandler(this.vhod03_Click);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(155, 118);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 20D;
            this.voltmetr1.Set_Center_str = "mA";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(160, 160);
            this.voltmetr1.TabIndex = 153;
            // 
            // voltage
            // 
            this.voltage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.voltage.Location = new System.Drawing.Point(38, 372);
            this.voltage.Name = "voltage";
            this.voltage.Set_Type = 0;
            this.voltage.Set_Value = 0;
            this.voltage.Size = new System.Drawing.Size(100, 85);
            this.voltage.TabIndex = 154;
            this.voltage.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.voltage_Value_Changed);
            // 
            // eject
            // 
            this.eject.BackColor = System.Drawing.Color.Transparent;
            this.eject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eject.BackgroundImage")));
            this.eject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eject.FlatAppearance.BorderSize = 0;
            this.eject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eject.Location = new System.Drawing.Point(164, 12);
            this.eject.Name = "eject";
            this.eject.Size = new System.Drawing.Size(148, 20);
            this.eject.TabIndex = 156;
            this.eject.UseVisualStyleBackColor = false;
            this.eject.Click += new System.EventHandler(this.eject_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.regNach);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 191);
            this.panel1.TabIndex = 157;
            this.panel1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "РЕГ. НАЧ. ОТСЧ.";
            // 
            // regNach
            // 
            this.regNach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.regNach.Location = new System.Drawing.Point(10, 12);
            this.regNach.Name = "regNach";
            this.regNach.Set_Type = 0;
            this.regNach.Set_Value = 50;
            this.regNach.Size = new System.Drawing.Size(100, 85);
            this.regNach.TabIndex = 0;
            this.regNach.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.regNach_Value_Changed);
            // 
            // vhodD
            // 
            this.vhodD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vhodD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vhodD.FlatAppearance.BorderSize = 0;
            this.vhodD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vhodD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vhodD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vhodD.Location = new System.Drawing.Point(359, 459);
            this.vhodD.Name = "vhodD";
            this.vhodD.Size = new System.Drawing.Size(90, 15);
            this.vhodD.TabIndex = 158;
            this.vhodD.UseVisualStyleBackColor = false;
            this.vhodD.Click += new System.EventHandler(this.vhodD_Click);
            // 
            // vyhodImit
            // 
            this.vyhodImit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vyhodImit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vyhodImit.FlatAppearance.BorderSize = 0;
            this.vyhodImit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vyhodImit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.vyhodImit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vyhodImit.Location = new System.Drawing.Point(38, 506);
            this.vyhodImit.Name = "vyhodImit";
            this.vyhodImit.Size = new System.Drawing.Size(90, 15);
            this.vyhodImit.TabIndex = 159;
            this.vyhodImit.UseVisualStyleBackColor = false;
            this.vyhodImit.Click += new System.EventHandler(this.vyhodImit_Click);
            // 
            // kalibr
            // 
            this.kalibr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.kalibr.Location = new System.Drawing.Point(38, 301);
            this.kalibr.Name = "kalibr";
            this.kalibr.Set_Type = 0;
            this.kalibr.Set_Value = 0;
            this.kalibr.Size = new System.Drawing.Size(100, 85);
            this.kalibr.TabIndex = 160;
            this.kalibr.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.kalibr_Value_Changed_1);
            // 
            // izmer
            // 
            this.izmer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.izmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.izmer.FlatAppearance.BorderSize = 0;
            this.izmer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.izmer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.izmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmer.Location = new System.Drawing.Point(38, 459);
            this.izmer.Name = "izmer";
            this.izmer.Size = new System.Drawing.Size(90, 15);
            this.izmer.TabIndex = 161;
            this.izmer.UseVisualStyleBackColor = false;
            this.izmer.Click += new System.EventHandler(this.razmer_Click);
            // 
            // generator
            // 
            this.generator.Location = new System.Drawing.Point(391, 608);
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(69, 40);
            this.generator.TabIndex = 162;
            this.generator.Text = "Генератор";
            this.generator.UseVisualStyleBackColor = true;
            this.generator.Visible = false;
            this.generator.Click += new System.EventHandler(this.generator_Click);
            // 
            // bsh001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(484, 674);
            this.Controls.Add(this.generator);
            this.Controls.Add(this.izmer);
            this.Controls.Add(this.kalibr);
            this.Controls.Add(this.vyhodImit);
            this.Controls.Add(this.vhodD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eject);
            this.Controls.Add(this.voltage);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.vhod03);
            this.Controls.Add(this.codes);
            this.Controls.Add(this.voltageContr);
            this.Controls.Add(this.imitator);
            this.Controls.Add(this.msek);
            this.Controls.Add(this.regZad);
            this.Controls.Add(this.bulb1);
            this.Controls.Add(this.otkl);
            this.Controls.Add(this.vkl);
            this.DoubleBuffered = true;
            this.Name = "bsh001";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "БШ-001";
            this.Controls.SetChildIndex(this.vkl, 0);
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.otkl, 0);
            this.Controls.SetChildIndex(this.bulb1, 0);
            this.Controls.SetChildIndex(this.regZad, 0);
            this.Controls.SetChildIndex(this.msek, 0);
            this.Controls.SetChildIndex(this.imitator, 0);
            this.Controls.SetChildIndex(this.voltageContr, 0);
            this.Controls.SetChildIndex(this.codes, 0);
            this.Controls.SetChildIndex(this.vhod03, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.voltage, 0);
            this.Controls.SetChildIndex(this.eject, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.vhodD, 0);
            this.Controls.SetChildIndex(this.vyhodImit, 0);
            this.Controls.SetChildIndex(this.kalibr, 0);
            this.Controls.SetChildIndex(this.izmer, 0);
            this.Controls.SetChildIndex(this.generator, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button vkl;
        public System.Windows.Forms.Button otkl;
        private bulb bulb1;
        private nPosSwitch imitator;
        private nPosSwitch voltageContr;
        private nPosSwitch codes;
        public nPosSwitch regZad;
        public nPosSwitch msek;
        private System.Windows.Forms.Button vhod03;
        private Potenzhiomert voltage;
        private System.Windows.Forms.Button eject;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Potenzhiomert regNach;
        private System.Windows.Forms.Button vhodD;
        private System.Windows.Forms.Button vyhodImit;
        private Potenzhiomert kalibr;
        public Voltmetr voltmetr1;
        private System.Windows.Forms.Button izmer;
        private System.Windows.Forms.Button generator;


    }
}