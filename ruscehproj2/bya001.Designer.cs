namespace ruscehproj2
{
    partial class bya001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bya001));
            this.ContrPar = new ruscehproj2.nPosSwitch();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
            this.potenzhiomert1 = new ruscehproj2.Potenzhiomert();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // ContrPar
            // 
            this.ContrPar.BackColor = System.Drawing.Color.Transparent;
            this.ContrPar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContrPar.BackgroundImage")));
            this.ContrPar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContrPar.Location = new System.Drawing.Point(252, 422);
            this.ContrPar.Name = "ContrPar";
            this.ContrPar.Size = new System.Drawing.Size(63, 70);
            this.ContrPar.Step = 1;
            this.ContrPar.TabIndex = 54;
            this.ContrPar.Click += new System.EventHandler(this.ContrPar_Click);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(206, 120);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 30D;
            this.voltmetr1.Set_Center_str = "V";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(160, 160);
            this.voltmetr1.TabIndex = 55;
            // 
            // potenzhiomert1
            // 
            this.potenzhiomert1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.potenzhiomert1.Location = new System.Drawing.Point(166, 522);
            this.potenzhiomert1.Name = "potenzhiomert1";
            this.potenzhiomert1.Set_Type = 0;
            this.potenzhiomert1.Set_Value = 50;
            this.potenzhiomert1.Size = new System.Drawing.Size(100, 85);
            this.potenzhiomert1.TabIndex = 56;
            this.potenzhiomert1.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert1_Value_Changed);
            // 
            // bya001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ruscehproj2.Resources.bya001_clean;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(567, 756);
            this.Controls.Add(this.potenzhiomert1);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.ContrPar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bya001";
            this.Text = "БЯ-001";
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.ContrPar, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.potenzhiomert1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private nPosSwitch ContrPar;
        private Voltmetr voltmetr1;
        private Potenzhiomert potenzhiomert1;
    }
}