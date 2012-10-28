namespace ruscehproj2
{
    partial class bt006
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bt006));
            this.mode1 = new ruscehproj2.nPosSwitch();
            this.mode2 = new ruscehproj2.nPosSwitch();
            this.tmb = new ruscehproj2.tumbler();
            this.setNull2 = new ruscehproj2.Potenzhiomert();
            this.setNull1 = new ruscehproj2.Potenzhiomert();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
            this.KBVn1 = new ruscehproj2.Potenzhiomert();
            this.bulb1 = new ruscehproj2.bulb();
            this.voltmetr2 = new ruscehproj2.Voltmetr();
            this.KBVn2 = new ruscehproj2.Potenzhiomert();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // mode1
            // 
            this.mode1.BackColor = System.Drawing.Color.Transparent;
            this.mode1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mode1.BackgroundImage")));
            this.mode1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mode1.Location = new System.Drawing.Point(89, 177);
            this.mode1.Name = "mode1";
            this.mode1.Size = new System.Drawing.Size(58, 64);
            this.mode1.Step = 1;
            this.mode1.TabIndex = 1;
            this.mode1.Click += new System.EventHandler(this.mode1_Click);
            // 
            // mode2
            // 
            this.mode2.BackColor = System.Drawing.Color.Transparent;
            this.mode2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mode2.BackgroundImage")));
            this.mode2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mode2.Location = new System.Drawing.Point(113, 509);
            this.mode2.Name = "mode2";
            this.mode2.Size = new System.Drawing.Size(58, 64);
            this.mode2.Step = 1;
            this.mode2.TabIndex = 1;
            this.mode2.Click += new System.EventHandler(this.mode2_Click);
            // 
            // tmb
            // 
            this.tmb.BackColor = System.Drawing.Color.Transparent;
            this.tmb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tmb.BackgroundImage")));
            this.tmb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tmb.isSided = false;
            this.tmb.Location = new System.Drawing.Point(193, 109);
            this.tmb.Name = "tmb";
            this.tmb.Set_Skin = 1;
            this.tmb.Size = new System.Drawing.Size(34, 34);
            this.tmb.State = true;
            this.tmb.TabIndex = 2;
            this.tmb.Click += new System.EventHandler(this.tumbler1_Click);
            // 
            // setNull2
            // 
            this.setNull2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.setNull2.Location = new System.Drawing.Point(168, 502);
            this.setNull2.Name = "setNull2";
            this.setNull2.Set_Type = 0;
            this.setNull2.Set_Value = 50;
            this.setNull2.Size = new System.Drawing.Size(100, 85);
            this.setNull2.TabIndex = 3;
            this.setNull2.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.setNull_Value_Changed);
            // 
            // setNull1
            // 
            this.setNull1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.setNull1.Location = new System.Drawing.Point(169, 137);
            this.setNull1.Name = "setNull1";
            this.setNull1.Set_Type = 0;
            this.setNull1.Set_Value = 0;
            this.setNull1.Size = new System.Drawing.Size(100, 85);
            this.setNull1.TabIndex = 3;
            this.setNull1.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.setNull1_Value_Changed);
            this.setNull1.MouseLeave += new System.EventHandler(this.setNull1_MouseLeave);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(250, 69);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 0.2D;
            this.voltmetr1.Set_Center_str = "КБВн";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(233, 204);
            this.voltmetr1.TabIndex = 4;
            this.voltmetr1.Click += new System.EventHandler(this.voltmetr1_Click);
            // 
            // KBVn1
            // 
            this.KBVn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.KBVn1.Location = new System.Drawing.Point(168, 203);
            this.KBVn1.Name = "KBVn1";
            this.KBVn1.Set_Type = 0;
            this.KBVn1.Set_Value = 0;
            this.KBVn1.Size = new System.Drawing.Size(100, 85);
            this.KBVn1.TabIndex = 3;
            this.KBVn1.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.KBVn1_Value_Changed);
            // 
            // bulb1
            // 
            this.bulb1.BackColor = System.Drawing.Color.Transparent;
            this.bulb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulb1.BackgroundImage")));
            this.bulb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bulb1.Location = new System.Drawing.Point(39, 103);
            this.bulb1.Name = "bulb1";
            this.bulb1.SetColor = "";
            this.bulb1.Size = new System.Drawing.Size(45, 42);
            this.bulb1.TabIndex = 5;
            // 
            // voltmetr2
            // 
            this.voltmetr2.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr2.BackgroundImage")));
            this.voltmetr2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr2.current_Value = 0;
            this.voltmetr2.Location = new System.Drawing.Point(250, 441);
            this.voltmetr2.Name = "voltmetr2";
            this.voltmetr2.Set_Bar_min = 0;
            this.voltmetr2.Set_Bar_N_bolt = 10;
            this.voltmetr2.Set_Bar_N_not_bolt = 50;
            this.voltmetr2.Set_Bar_N_tzhifra = 10;
            this.voltmetr2.Set_Bar_step = 0.2D;
            this.voltmetr2.Set_Center_str = "КБВн";
            this.voltmetr2.Set_Value = 0;
            this.voltmetr2.Size = new System.Drawing.Size(233, 204);
            this.voltmetr2.TabIndex = 6;
            // 
            // KBVn2
            // 
            this.KBVn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.KBVn2.Location = new System.Drawing.Point(169, 584);
            this.KBVn2.Name = "KBVn2";
            this.KBVn2.Set_Type = 0;
            this.KBVn2.Set_Value = 0;
            this.KBVn2.Size = new System.Drawing.Size(100, 85);
            this.KBVn2.TabIndex = 7;
            this.KBVn2.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.KBVn2_Value_Changed);
            // 
            // bt006
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(508, 706);
            this.Controls.Add(this.KBVn2);
            this.Controls.Add(this.voltmetr2);
            this.Controls.Add(this.mode1);
            this.Controls.Add(this.bulb1);
            this.Controls.Add(this.mode2);
            this.Controls.Add(this.setNull2);
            this.Controls.Add(this.tmb);
            this.Controls.Add(this.setNull1);
            this.Controls.Add(this.KBVn1);
            this.Controls.Add(this.voltmetr1);
            this.Name = "bt006";
            this.Text = "БТ-005 и БТ-006";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bt006_FormClosing);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.KBVn1, 0);
            this.Controls.SetChildIndex(this.setNull1, 0);
            this.Controls.SetChildIndex(this.tmb, 0);
            this.Controls.SetChildIndex(this.setNull2, 0);
            this.Controls.SetChildIndex(this.mode2, 0);
            this.Controls.SetChildIndex(this.bulb1, 0);
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.mode1, 0);
            this.Controls.SetChildIndex(this.voltmetr2, 0);
            this.Controls.SetChildIndex(this.KBVn2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private nPosSwitch mode1;
        private nPosSwitch mode2;
        private tumbler tmb;
        private Potenzhiomert setNull2;
        private Potenzhiomert setNull1;
        private Potenzhiomert KBVn1;
        private bulb bulb1;
        private Voltmetr voltmetr2;
        private Potenzhiomert KBVn2;
        public Voltmetr voltmetr1;

    }
}