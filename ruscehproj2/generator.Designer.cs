namespace ruscehproj2
{
    partial class generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(generator));
            this.levelControl = new System.Windows.Forms.Button();
            this.mode = new ruscehproj2.tumbler();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sinhr = new ruscehproj2.ground();
            this.label4 = new System.Windows.Forms.Label();
            this.atten = new ruscehproj2.Potenzhiomert();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
            this.label5 = new System.Windows.Forms.Label();
            this.freq = new ruscehproj2.Potenzhiomert();
            this.output = new ruscehproj2.Potenzhiomert();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // levelControl
            // 
            this.levelControl.BackColor = System.Drawing.Color.Transparent;
            this.levelControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("levelControl.BackgroundImage")));
            this.levelControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.levelControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.levelControl.FlatAppearance.BorderSize = 0;
            this.levelControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.levelControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.levelControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.levelControl.Location = new System.Drawing.Point(357, 262);
            this.levelControl.Name = "levelControl";
            this.levelControl.Size = new System.Drawing.Size(117, 53);
            this.levelControl.TabIndex = 142;
            this.levelControl.UseVisualStyleBackColor = false;
            this.levelControl.Click += new System.EventHandler(this.levelControl_Click);
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.Color.Transparent;
            this.mode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mode.BackgroundImage")));
            this.mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mode.isSided = false;
            this.mode.Location = new System.Drawing.Point(27, 262);
            this.mode.Name = "mode";
            this.mode.Set_Skin = 1;
            this.mode.Size = new System.Drawing.Size(32, 32);
            this.mode.State = false;
            this.mode.TabIndex = 143;
            this.mode.Click += new System.EventHandler(this.mode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 144;
            this.label1.Text = "РОД РАБОТЫ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 145;
            this.label2.Text = "ВНУТР\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 146;
            this.label3.Text = "ВНЕШ\r\n";
            // 
            // sinhr
            // 
            this.sinhr.BackColor = System.Drawing.Color.Transparent;
            this.sinhr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sinhr.BackgroundImage")));
            this.sinhr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sinhr.Location = new System.Drawing.Point(446, 227);
            this.sinhr.Name = "sinhr";
            this.sinhr.Size = new System.Drawing.Size(16, 16);
            this.sinhr.TabIndex = 147;
            this.sinhr.Click += new System.EventHandler(this.sinhr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(238, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 13);
            this.label4.TabIndex = 148;
            this.label4.Text = "СИНХРОНИЗАЦИЯ ОСЦИЛЛОГРАФА";
            // 
            // atten
            // 
            this.atten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.atten.Location = new System.Drawing.Point(6, 46);
            this.atten.Name = "atten";
            this.atten.Set_Type = 0;
            this.atten.Set_Value = 0;
            this.atten.Size = new System.Drawing.Size(100, 85);
            this.atten.TabIndex = 149;
            this.atten.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.atten_Value_Changed);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(313, 46);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 60D;
            this.voltmetr1.Set_Center_str = "dB";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(160, 160);
            this.voltmetr1.TabIndex = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 151;
            this.label5.Text = "АТТЕНЮАТОР";
            // 
            // freq
            // 
            this.freq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.freq.Location = new System.Drawing.Point(112, 46);
            this.freq.Name = "freq";
            this.freq.Set_Type = 0;
            this.freq.Set_Value = 0;
            this.freq.Size = new System.Drawing.Size(100, 85);
            this.freq.TabIndex = 152;
            this.freq.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.freq_Value_Changed);
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.output.Location = new System.Drawing.Point(207, 46);
            this.output.Name = "output";
            this.output.Set_Type = 0;
            this.output.Set_Value = 0;
            this.output.Size = new System.Drawing.Size(100, 85);
            this.output.TabIndex = 153;
            this.output.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.output_Value_Changed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(99, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 154;
            this.label6.Text = "УСТ. ЧАСТОТЫ MHZ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(218, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 155;
            this.label7.Text = "УСТ.ВЫХОДА dBW ";
            // 
            // generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(474, 316);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.output);
            this.Controls.Add(this.freq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.atten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sinhr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.levelControl);
            this.Name = "generator";
            this.Text = "Генератор";
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.levelControl, 0);
            this.Controls.SetChildIndex(this.mode, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.sinhr, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.atten, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.freq, 0);
            this.Controls.SetChildIndex(this.output, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button levelControl;
        private tumbler mode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ground sinhr;
        private System.Windows.Forms.Label label4;
        private Potenzhiomert atten;
        private Voltmetr voltmetr1;
        private System.Windows.Forms.Label label5;
        private Potenzhiomert freq;
        private Potenzhiomert output;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

    }
}