namespace ruscehproj2
{
    partial class bp103
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bp103));
            this.tumbler1 = new ruscehproj2.tumbler();
            this.volt = new ruscehproj2.Potenzhiomert();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
            this.bulb1 = new ruscehproj2.bulb();
            this.bulb2 = new ruscehproj2.bulb();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // tumbler1
            // 
            this.tumbler1.BackColor = System.Drawing.Color.Transparent;
            this.tumbler1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tumbler1.BackgroundImage")));
            this.tumbler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tumbler1.isSided = false;
            this.tumbler1.Location = new System.Drawing.Point(323, 200);
            this.tumbler1.Name = "tumbler1";
            this.tumbler1.Set_Skin = 1;
            this.tumbler1.Size = new System.Drawing.Size(47, 114);
            this.tumbler1.State = false;
            this.tumbler1.TabIndex = 0;
            this.tumbler1.Click += new System.EventHandler(this.bp001_tumbler1_Click);
            // 
            // volt
            // 
            this.volt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.volt.Location = new System.Drawing.Point(165, 166);
            this.volt.Name = "volt";
            this.volt.Set_Type = 0;
            this.volt.Set_Value = 0;
            this.volt.Size = new System.Drawing.Size(100, 85);
            this.volt.TabIndex = 2;
            this.volt.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert1_Value_Changed);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(12, 120);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 10D;
            this.voltmetr1.Set_Center_str = "V";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(147, 145);
            this.voltmetr1.TabIndex = 3;
            // 
            // bulb1
            // 
            this.bulb1.BackColor = System.Drawing.Color.Transparent;
            this.bulb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulb1.BackgroundImage")));
            this.bulb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bulb1.Location = new System.Drawing.Point(12, 30);
            this.bulb1.Name = "bulb1";
            this.bulb1.SetColor = "";
            this.bulb1.Size = new System.Drawing.Size(40, 40);
            this.bulb1.TabIndex = 4;
            // 
            // bulb2
            // 
            this.bulb2.BackColor = System.Drawing.Color.Transparent;
            this.bulb2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulb2.BackgroundImage")));
            this.bulb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bulb2.Location = new System.Drawing.Point(55, 30);
            this.bulb2.Name = "bulb2";
            this.bulb2.SetColor = "";
            this.bulb2.Size = new System.Drawing.Size(40, 40);
            this.bulb2.TabIndex = 4;
            // 
            // bp103
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ruscehproj2.Resources.bp103;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(412, 588);
            this.Controls.Add(this.tumbler1);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.bulb1);
            this.Controls.Add(this.bulb2);
            this.Controls.Add(this.volt);
            this.Name = "bp103";
            this.Text = "БП-103";
            this.Controls.SetChildIndex(this.volt, 0);
            this.Controls.SetChildIndex(this.bulb2, 0);
            this.Controls.SetChildIndex(this.bulb1, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.tumbler1, 0);
            this.Controls.SetChildIndex(this.str, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public tumbler tumbler1;
        public Potenzhiomert volt;
        public Voltmetr voltmetr1;
        private bulb bulb1;
        private bulb bulb2;


    }
}