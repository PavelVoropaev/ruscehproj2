namespace ruscehproj2
{
    partial class br007
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(br007));
            this.tokSmes = new ruscehproj2.Potenzhiomert();
            this.getNastr = new ruscehproj2.Potenzhiomert();
            this.door1 = new System.Windows.Forms.Button();
            this.door2 = new System.Windows.Forms.Button();
            this.door3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // tokSmes
            // 
            this.tokSmes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.tokSmes.Location = new System.Drawing.Point(214, 201);
            this.tokSmes.Name = "tokSmes";
            this.tokSmes.Set_Type = 0;
            this.tokSmes.Set_Value = 0;
            this.tokSmes.Size = new System.Drawing.Size(100, 85);
            this.tokSmes.TabIndex = 1;
            this.tokSmes.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.tokSmes_Value_Changed);
            // 
            // getNastr
            // 
            this.getNastr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.getNastr.Location = new System.Drawing.Point(579, 486);
            this.getNastr.Name = "getNastr";
            this.getNastr.Set_Type = 0;
            this.getNastr.Set_Value = 0;
            this.getNastr.Size = new System.Drawing.Size(100, 85);
            this.getNastr.TabIndex = 2;
            this.getNastr.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.getNastr_Value_Changed);
            // 
            // door1
            // 
            this.door1.BackColor = System.Drawing.Color.Transparent;
            this.door1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("door1.BackgroundImage")));
            this.door1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.door1.FlatAppearance.BorderSize = 0;
            this.door1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.door1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.door1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door1.Location = new System.Drawing.Point(406, 146);
            this.door1.Name = "door1";
            this.door1.Size = new System.Drawing.Size(324, 277);
            this.door1.TabIndex = 142;
            this.door1.UseVisualStyleBackColor = false;
            this.door1.Click += new System.EventHandler(this.door1_Click);
            // 
            // door2
            // 
            this.door2.BackColor = System.Drawing.Color.Transparent;
            this.door2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("door2.BackgroundImage")));
            this.door2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.door2.FlatAppearance.BorderSize = 0;
            this.door2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.door2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.door2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door2.Location = new System.Drawing.Point(406, 146);
            this.door2.Name = "door2";
            this.door2.Size = new System.Drawing.Size(324, 277);
            this.door2.TabIndex = 143;
            this.door2.UseVisualStyleBackColor = false;
            this.door2.Click += new System.EventHandler(this.door2_Click);
            // 
            // door3
            // 
            this.door3.BackColor = System.Drawing.Color.Transparent;
            this.door3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.door3.FlatAppearance.BorderSize = 0;
            this.door3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.door3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.door3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door3.Location = new System.Drawing.Point(406, 146);
            this.door3.Name = "door3";
            this.door3.Size = new System.Drawing.Size(324, 277);
            this.door3.TabIndex = 144;
            this.door3.UseVisualStyleBackColor = false;
            this.door3.Click += new System.EventHandler(this.door3_Click);
            // 
            // br007
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(810, 574);
            this.Controls.Add(this.door3);
            this.Controls.Add(this.door2);
            this.Controls.Add(this.door1);
            this.Controls.Add(this.getNastr);
            this.Controls.Add(this.tokSmes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "br007";
            this.Text = "БР-007";
            this.Controls.SetChildIndex(this.tokSmes, 0);
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.getNastr, 0);
            this.Controls.SetChildIndex(this.door1, 0);
            this.Controls.SetChildIndex(this.door2, 0);
            this.Controls.SetChildIndex(this.door3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Potenzhiomert tokSmes;
        private Potenzhiomert getNastr;
        private System.Windows.Forms.Button door1;
        private System.Windows.Forms.Button door2;
        private System.Windows.Forms.Button door3;
    }
}