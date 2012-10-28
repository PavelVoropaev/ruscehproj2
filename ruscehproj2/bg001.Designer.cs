namespace ruscehproj2
{
    partial class bg001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bg001));
            this.mode = new ruscehproj2.nPosSwitch();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
            this.potenzhiomert1 = new ruscehproj2.Potenzhiomert();
            this.potenzhiomert2 = new ruscehproj2.Potenzhiomert();
            this.potenzhiomert3 = new ruscehproj2.Potenzhiomert();
            this.potenzhiomert4 = new ruscehproj2.Potenzhiomert();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.Color.Transparent;
            this.mode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mode.BackgroundImage")));
            this.mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mode.Location = new System.Drawing.Point(342, 352);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(77, 87);
            this.mode.Step = 0;
            this.mode.TabIndex = 1;
            this.mode.Click += new System.EventHandler(this.mode_Click);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(79, 327);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 10D;
            this.voltmetr1.Set_Center_str = "mA";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(152, 152);
            this.voltmetr1.TabIndex = 2;
            // 
            // potenzhiomert1
            // 
            this.potenzhiomert1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.potenzhiomert1.Location = new System.Drawing.Point(70, 540);
            this.potenzhiomert1.Name = "potenzhiomert1";
            this.potenzhiomert1.Set_Type = 0;
            this.potenzhiomert1.Set_Value = 0;
            this.potenzhiomert1.Size = new System.Drawing.Size(100, 111);
            this.potenzhiomert1.TabIndex = 3;
            this.potenzhiomert1.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert1_Value_Changed);
            // 
            // potenzhiomert2
            // 
            this.potenzhiomert2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.potenzhiomert2.Location = new System.Drawing.Point(384, 527);
            this.potenzhiomert2.Name = "potenzhiomert2";
            this.potenzhiomert2.Set_Type = 0;
            this.potenzhiomert2.Set_Value = 0;
            this.potenzhiomert2.Size = new System.Drawing.Size(100, 85);
            this.potenzhiomert2.TabIndex = 3;
            this.potenzhiomert2.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert2_Value_Changed);
            // 
            // potenzhiomert3
            // 
            this.potenzhiomert3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.potenzhiomert3.Location = new System.Drawing.Point(65, 168);
            this.potenzhiomert3.Name = "potenzhiomert3";
            this.potenzhiomert3.Set_Type = 0;
            this.potenzhiomert3.Set_Value = 0;
            this.potenzhiomert3.Size = new System.Drawing.Size(100, 85);
            this.potenzhiomert3.TabIndex = 3;
            this.potenzhiomert3.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert3_Value_Changed);
            // 
            // potenzhiomert4
            // 
            this.potenzhiomert4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.potenzhiomert4.Location = new System.Drawing.Point(381, 161);
            this.potenzhiomert4.Name = "potenzhiomert4";
            this.potenzhiomert4.Set_Type = 0;
            this.potenzhiomert4.Set_Value = 0;
            this.potenzhiomert4.Size = new System.Drawing.Size(100, 85);
            this.potenzhiomert4.TabIndex = 3;
            this.potenzhiomert4.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert4_Value_Changed);
            // 
            // bg001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ruscehproj2.Resources.bg001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 756);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.potenzhiomert1);
            this.Controls.Add(this.potenzhiomert2);
            this.Controls.Add(this.potenzhiomert3);
            this.Controls.Add(this.potenzhiomert4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bg001";
            this.Text = "БГ-001";
            this.Controls.SetChildIndex(this.potenzhiomert4, 0);
            this.Controls.SetChildIndex(this.potenzhiomert3, 0);
            this.Controls.SetChildIndex(this.potenzhiomert2, 0);
            this.Controls.SetChildIndex(this.potenzhiomert1, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.mode, 0);
            this.Controls.SetChildIndex(this.str, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private nPosSwitch mode;
        private Voltmetr voltmetr1;
        private Potenzhiomert potenzhiomert1;
        private Potenzhiomert potenzhiomert2;
        private Potenzhiomert potenzhiomert3;
        private Potenzhiomert potenzhiomert4;

    }
}