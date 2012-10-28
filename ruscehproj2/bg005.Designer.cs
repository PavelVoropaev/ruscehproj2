namespace ruscehproj2
{
    partial class bg005
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bg005));
            this.eject = new System.Windows.Forms.Button();
            this.potenzhiomert1 = new ruscehproj2.Potenzhiomert();
            this.potenzhiomert2 = new ruscehproj2.Potenzhiomert();
            this.potenzhiomert3 = new ruscehproj2.Potenzhiomert();
            this.contr = new ruscehproj2.button();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // eject
            // 
            this.eject.BackColor = System.Drawing.Color.Transparent;
            this.eject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eject.FlatAppearance.BorderSize = 0;
            this.eject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.eject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.eject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eject.Location = new System.Drawing.Point(147, 58);
            this.eject.Name = "eject";
            this.eject.Size = new System.Drawing.Size(211, 224);
            this.eject.TabIndex = 142;
            this.eject.UseVisualStyleBackColor = false;
            this.eject.Click += new System.EventHandler(this.eject_Click);
            // 
            // potenzhiomert1
            // 
            this.potenzhiomert1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.potenzhiomert1.Location = new System.Drawing.Point(151, 283);
            this.potenzhiomert1.Name = "potenzhiomert1";
            this.potenzhiomert1.Set_Type = 0;
            this.potenzhiomert1.Set_Value = 0;
            this.potenzhiomert1.Size = new System.Drawing.Size(100, 85);
            this.potenzhiomert1.TabIndex = 143;
            this.potenzhiomert1.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert1_Value_Changed);
            // 
            // potenzhiomert2
            // 
            this.potenzhiomert2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.potenzhiomert2.Location = new System.Drawing.Point(-13, 249);
            this.potenzhiomert2.Name = "potenzhiomert2";
            this.potenzhiomert2.Set_Type = 0;
            this.potenzhiomert2.Set_Value = 0;
            this.potenzhiomert2.Size = new System.Drawing.Size(100, 85);
            this.potenzhiomert2.TabIndex = 143;
            this.potenzhiomert2.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert2_Value_Changed);
            // 
            // potenzhiomert3
            // 
            this.potenzhiomert3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.potenzhiomert3.Location = new System.Drawing.Point(430, 67);
            this.potenzhiomert3.Name = "potenzhiomert3";
            this.potenzhiomert3.Set_Type = 0;
            this.potenzhiomert3.Set_Value = 0;
            this.potenzhiomert3.Size = new System.Drawing.Size(100, 85);
            this.potenzhiomert3.TabIndex = 143;
            this.potenzhiomert3.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert3_Value_Changed);
            // 
            // contr
            // 
            this.contr.BackColor = System.Drawing.Color.Transparent;
            this.contr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contr.BackgroundImage")));
            this.contr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contr.Location = new System.Drawing.Point(514, 207);
            this.contr.Name = "contr";
            this.contr.Size = new System.Drawing.Size(35, 34);
            this.contr.TabIndex = 144;
            this.contr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.contr_MouseDown);
            this.contr.MouseUp += new System.Windows.Forms.MouseEventHandler(this.contr_MouseUp);
            // 
            // bg005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ruscehproj2.Resources.bg005;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 408);
            this.Controls.Add(this.potenzhiomert2);
            this.Controls.Add(this.potenzhiomert1);
            this.Controls.Add(this.contr);
            this.Controls.Add(this.eject);
            this.Controls.Add(this.potenzhiomert3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bg005";
            this.Text = "БГ-005";
            this.Load += new System.EventHandler(this.bg005_Load);
            this.Controls.SetChildIndex(this.potenzhiomert3, 0);
            this.Controls.SetChildIndex(this.eject, 0);
            this.Controls.SetChildIndex(this.contr, 0);
            this.Controls.SetChildIndex(this.potenzhiomert1, 0);
            this.Controls.SetChildIndex(this.potenzhiomert2, 0);
            this.Controls.SetChildIndex(this.str, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button eject;
        private Potenzhiomert potenzhiomert1;
        private Potenzhiomert potenzhiomert2;
        private Potenzhiomert potenzhiomert3;
        private button contr;
    }
}