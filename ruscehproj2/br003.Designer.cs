namespace ruscehproj2
{
    partial class br003
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(br003));
            this.vkl = new System.Windows.Forms.Button();
            this.otkl = new System.Windows.Forms.Button();
            this.mode = new ruscehproj2.nPosSwitch();
            this.mechZero = new ruscehproj2.Potenzhiomert();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
            this.preVyh = new ruscehproj2.Potenzhiomert();
            this.vyhod = new ruscehproj2.Potenzhiomert();
            this.getPwr = new ruscehproj2.Potenzhiomert();
            this.de = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
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
            this.vkl.Location = new System.Drawing.Point(234, 543);
            this.vkl.Name = "vkl";
            this.vkl.Size = new System.Drawing.Size(32, 27);
            this.vkl.TabIndex = 12;
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
            this.otkl.Location = new System.Drawing.Point(316, 543);
            this.otkl.Name = "otkl";
            this.otkl.Size = new System.Drawing.Size(26, 30);
            this.otkl.TabIndex = 13;
            this.otkl.UseVisualStyleBackColor = false;
            this.otkl.Click += new System.EventHandler(this.otkl_Click);
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.Color.Transparent;
            this.mode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mode.BackgroundImage")));
            this.mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mode.Location = new System.Drawing.Point(126, 389);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(67, 67);
            this.mode.Step = 0;
            this.mode.TabIndex = 14;
            this.mode.Click += new System.EventHandler(this.mode_Click);
            // 
            // mechZero
            // 
            this.mechZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.mechZero.Location = new System.Drawing.Point(103, 287);
            this.mechZero.Name = "mechZero";
            this.mechZero.Set_Type = 0;
            this.mechZero.Set_Value = 75;
            this.mechZero.Size = new System.Drawing.Size(110, 91);
            this.mechZero.TabIndex = 15;
            this.mechZero.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.mechZero_Value_Changed);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(63, 167);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 0.2D;
            this.voltmetr1.Set_Center_str = "mA";
            this.voltmetr1.Set_Value = 5;
            this.voltmetr1.Size = new System.Drawing.Size(185, 176);
            this.voltmetr1.TabIndex = 16;
            this.voltmetr1.Click += new System.EventHandler(this.voltmetr1_Click);
            // 
            // preVyh
            // 
            this.preVyh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.preVyh.Enabled = false;
            this.preVyh.Location = new System.Drawing.Point(302, 87);
            this.preVyh.Name = "preVyh";
            this.preVyh.Set_Type = 0;
            this.preVyh.Set_Value = 70;
            this.preVyh.Size = new System.Drawing.Size(100, 85);
            this.preVyh.TabIndex = 17;
            this.preVyh.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.preVyh_Value_Changed);
            // 
            // vyhod
            // 
            this.vyhod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.vyhod.Enabled = false;
            this.vyhod.Location = new System.Drawing.Point(455, 89);
            this.vyhod.Name = "vyhod";
            this.vyhod.Set_Type = 0;
            this.vyhod.Set_Value = 75;
            this.vyhod.Size = new System.Drawing.Size(100, 85);
            this.vyhod.TabIndex = 18;
            this.vyhod.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.vyhod_Value_Changed);
            // 
            // getPwr
            // 
            this.getPwr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.getPwr.Enabled = false;
            this.getPwr.Location = new System.Drawing.Point(422, 389);
            this.getPwr.Name = "getPwr";
            this.getPwr.Set_Type = 0;
            this.getPwr.Set_Value = 80;
            this.getPwr.Size = new System.Drawing.Size(100, 85);
            this.getPwr.TabIndex = 19;
            this.getPwr.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.getPwr_Value_Changed);
            // 
            // de
            // 
            this.de.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.de.Cursor = System.Windows.Forms.Cursors.Hand;
            this.de.FlatAppearance.BorderSize = 0;
            this.de.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.de.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.de.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.de.Location = new System.Drawing.Point(85, 502);
            this.de.Name = "de";
            this.de.Size = new System.Drawing.Size(25, 21);
            this.de.TabIndex = 150;
            this.de.UseVisualStyleBackColor = false;
            this.de.Click += new System.EventHandler(this.de_Click);
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.a.Cursor = System.Windows.Forms.Cursors.Hand;
            this.a.FlatAppearance.BorderSize = 0;
            this.a.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.a.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a.Location = new System.Drawing.Point(134, 502);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(25, 21);
            this.a.TabIndex = 151;
            this.a.UseVisualStyleBackColor = false;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // br003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ruscehproj2.Resources.br003;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(577, 764);
            this.Controls.Add(this.a);
            this.Controls.Add(this.de);
            this.Controls.Add(this.getPwr);
            this.Controls.Add(this.vyhod);
            this.Controls.Add(this.preVyh);
            this.Controls.Add(this.mechZero);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.otkl);
            this.Controls.Add(this.vkl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "br003";
            this.Text = "БР-003";
            this.Controls.SetChildIndex(this.vkl, 0);
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.otkl, 0);
            this.Controls.SetChildIndex(this.mode, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.mechZero, 0);
            this.Controls.SetChildIndex(this.preVyh, 0);
            this.Controls.SetChildIndex(this.vyhod, 0);
            this.Controls.SetChildIndex(this.getPwr, 0);
            this.Controls.SetChildIndex(this.de, 0);
            this.Controls.SetChildIndex(this.a, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        public System.Windows.Forms.Button vkl;
        public System.Windows.Forms.Button otkl;
        private nPosSwitch mode;
        private Potenzhiomert mechZero;
        private Voltmetr voltmetr1;
        private Potenzhiomert preVyh;
        private Potenzhiomert vyhod;
        private Potenzhiomert getPwr;
        private System.Windows.Forms.Button de;
        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Timer timer1;




    }
}