namespace ruscehproj2
{
    partial class bv012
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bv012));
            this.voltageCheck = new ruscehproj2.nPosSwitch();
            this.vkl14 = new ruscehproj2.button();
            this.otkl14 = new ruscehproj2.button();
            this.otkl = new ruscehproj2.button();
            this.selsin = new ruscehproj2.button();
            this.selsinZero = new ruscehproj2.Potenzhiomert();
            this.vkl1 = new ruscehproj2.button();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
            this.bulb1 = new ruscehproj2.bulb();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // voltageCheck
            // 
            this.voltageCheck.BackColor = System.Drawing.Color.Transparent;
            this.voltageCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltageCheck.BackgroundImage")));
            this.voltageCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltageCheck.Location = new System.Drawing.Point(208, 324);
            this.voltageCheck.Name = "voltageCheck";
            this.voltageCheck.Size = new System.Drawing.Size(70, 70);
            this.voltageCheck.Step = 0;
            this.voltageCheck.TabIndex = 0;
            this.voltageCheck.Click += new System.EventHandler(this.voltageCheck_Click);
            // 
            // vkl14
            // 
            this.vkl14.BackColor = System.Drawing.Color.Transparent;
            this.vkl14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vkl14.BackgroundImage")));
            this.vkl14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vkl14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vkl14.Location = new System.Drawing.Point(336, 96);
            this.vkl14.Name = "vkl14";
            this.vkl14.Size = new System.Drawing.Size(31, 33);
            this.vkl14.TabIndex = 15;
            this.vkl14.Click += new System.EventHandler(this.vkl12_Click);
            // 
            // otkl14
            // 
            this.otkl14.BackColor = System.Drawing.Color.Transparent;
            this.otkl14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("otkl14.BackgroundImage")));
            this.otkl14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.otkl14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otkl14.Location = new System.Drawing.Point(390, 96);
            this.otkl14.Name = "otkl14";
            this.otkl14.Size = new System.Drawing.Size(31, 33);
            this.otkl14.TabIndex = 15;
            this.otkl14.Click += new System.EventHandler(this.otkl14_Click);
            // 
            // otkl
            // 
            this.otkl.BackColor = System.Drawing.Color.Transparent;
            this.otkl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("otkl.BackgroundImage")));
            this.otkl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.otkl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otkl.Location = new System.Drawing.Point(197, 573);
            this.otkl.Name = "otkl";
            this.otkl.Size = new System.Drawing.Size(31, 33);
            this.otkl.TabIndex = 15;
            this.otkl.Click += new System.EventHandler(this.otkl_Click);
            // 
            // selsin
            // 
            this.selsin.BackColor = System.Drawing.Color.Transparent;
            this.selsin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selsin.BackgroundImage")));
            this.selsin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selsin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selsin.Location = new System.Drawing.Point(84, 415);
            this.selsin.Name = "selsin";
            this.selsin.Size = new System.Drawing.Size(31, 33);
            this.selsin.TabIndex = 16;
            this.selsin.Click += new System.EventHandler(this.selsin_Click);
            // 
            // selsinZero
            // 
            this.selsinZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.selsinZero.Location = new System.Drawing.Point(53, 481);
            this.selsinZero.Name = "selsinZero";
            this.selsinZero.Set_Type = 0;
            this.selsinZero.Set_Value = 0;
            this.selsinZero.Size = new System.Drawing.Size(100, 85);
            this.selsinZero.TabIndex = 17;
            this.selsinZero.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert1_Value_Changed);
            // 
            // vkl1
            // 
            this.vkl1.BackColor = System.Drawing.Color.Transparent;
            this.vkl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vkl1.BackgroundImage")));
            this.vkl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.vkl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vkl1.Location = new System.Drawing.Point(254, 573);
            this.vkl1.Name = "vkl1";
            this.vkl1.Size = new System.Drawing.Size(31, 33);
            this.vkl1.TabIndex = 18;
            this.vkl1.Click += new System.EventHandler(this.vkl1_Click);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(161, 87);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 10D;
            this.voltmetr1.Set_Center_str = "mA";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(160, 160);
            this.voltmetr1.TabIndex = 19;
            // 
            // bulb1
            // 
            this.bulb1.BackColor = System.Drawing.Color.Transparent;
            this.bulb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bulb1.BackgroundImage")));
            this.bulb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bulb1.Location = new System.Drawing.Point(219, 444);
            this.bulb1.Name = "bulb1";
            this.bulb1.SetColor = "";
            this.bulb1.Size = new System.Drawing.Size(39, 41);
            this.bulb1.TabIndex = 20;
            // 
            // bv012
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ruscehproj2.Resources.bv012_clean;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(485, 668);
            this.Controls.Add(this.bulb1);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.vkl1);
            this.Controls.Add(this.selsinZero);
            this.Controls.Add(this.selsin);
            this.Controls.Add(this.otkl);
            this.Controls.Add(this.otkl14);
            this.Controls.Add(this.vkl14);
            this.Controls.Add(this.voltageCheck);
            this.Name = "bv012";
            this.Text = "БВ-012";
            this.Controls.SetChildIndex(this.voltageCheck, 0);
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.vkl14, 0);
            this.Controls.SetChildIndex(this.otkl14, 0);
            this.Controls.SetChildIndex(this.otkl, 0);
            this.Controls.SetChildIndex(this.selsin, 0);
            this.Controls.SetChildIndex(this.selsinZero, 0);
            this.Controls.SetChildIndex(this.vkl1, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.bulb1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private nPosSwitch voltageCheck;
        private button otkl;
        private button selsin;
        private Potenzhiomert selsinZero;
        private button vkl1;
        private Voltmetr voltmetr1;
        public button vkl14;
        public button otkl14;
        private bulb bulb1;
    }
}