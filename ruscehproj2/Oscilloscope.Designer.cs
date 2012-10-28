namespace ruscehproj2
{
    partial class Oscilloscope
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oscilloscope));
            this.picture_Box_for_Oscilloscope1 = new ruscehproj2.Picture_Box_for_Oscilloscope();
            this.voltageX = new ruscehproj2.Potenzhiomert();
            this.voltageY = new ruscehproj2.Potenzhiomert();
            this.generator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_Box_for_Oscilloscope1
            // 
            this.picture_Box_for_Oscilloscope1.Location = new System.Drawing.Point(137, 52);
            this.picture_Box_for_Oscilloscope1.Name = "picture_Box_for_Oscilloscope1";
            this.picture_Box_for_Oscilloscope1.Set_Case_Grafics = 0;
            this.picture_Box_for_Oscilloscope1.Set_mX = 1D;
            this.picture_Box_for_Oscilloscope1.Set_mY = 1D;
            this.picture_Box_for_Oscilloscope1.Size = new System.Drawing.Size(250, 187);
            this.picture_Box_for_Oscilloscope1.TabIndex = 11;
            this.picture_Box_for_Oscilloscope1.Click += new System.EventHandler(this.picture_Box_for_Oscilloscope1_Click);
            // 
            // voltageX
            // 
            this.voltageX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.voltageX.Location = new System.Drawing.Point(542, 190);
            this.voltageX.Name = "voltageX";
            this.voltageX.Set_Type = 0;
            this.voltageX.Set_Value = 50;
            this.voltageX.Size = new System.Drawing.Size(100, 85);
            this.voltageX.TabIndex = 14;
            this.voltageX.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert1_Value_Changed);
            // 
            // voltageY
            // 
            this.voltageY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.voltageY.Location = new System.Drawing.Point(88, 338);
            this.voltageY.Name = "voltageY";
            this.voltageY.Set_Type = 0;
            this.voltageY.Set_Value = 50;
            this.voltageY.Size = new System.Drawing.Size(100, 85);
            this.voltageY.TabIndex = 14;
            this.voltageY.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert2_Value_Changed);
            // 
            // generator
            // 
            this.generator.Location = new System.Drawing.Point(12, 371);
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(70, 43);
            this.generator.TabIndex = 15;
            this.generator.Text = "Генератор";
            this.generator.UseVisualStyleBackColor = true;
            this.generator.Click += new System.EventHandler(this.generator_Click);
            // 
            // Oscilloscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 426);
            this.Controls.Add(this.picture_Box_for_Oscilloscope1);
            this.Controls.Add(this.voltageY);
            this.Controls.Add(this.generator);
            this.Controls.Add(this.voltageX);
            this.DoubleBuffered = true;
            this.Name = "Oscilloscope";
            this.Text = "Развертка по X";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Oscilloscope_FormClosing);
            this.Controls.SetChildIndex(this.voltageX, 0);
            this.Controls.SetChildIndex(this.generator, 0);
            this.Controls.SetChildIndex(this.voltageY, 0);
            this.Controls.SetChildIndex(this.picture_Box_for_Oscilloscope1, 0);
            this.Controls.SetChildIndex(this.str, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Picture_Box_for_Oscilloscope picture_Box_for_Oscilloscope1;
        public Potenzhiomert voltageY;
        public Potenzhiomert voltageX;
        private System.Windows.Forms.Button generator;
    }
}