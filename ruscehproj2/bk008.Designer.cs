namespace ruscehproj2
{
    partial class bk008
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bk008));
            this.mode = new ruscehproj2.nPosSwitch();
            this.voltmetr1 = new ruscehproj2.Voltmetr();
            this.pwr = new ruscehproj2.tumbler();
            this.ignite = new ruscehproj2.button();
            this.stop = new ruscehproj2.button();
            this.tokSHG = new ruscehproj2.Potenzhiomert();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.Color.Transparent;
            this.mode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mode.BackgroundImage")));
            this.mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mode.Location = new System.Drawing.Point(81, 212);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(90, 90);
            this.mode.Step = 0;
            this.mode.TabIndex = 0;
            this.mode.Click += new System.EventHandler(this.mode_Click);
            // 
            // voltmetr1
            // 
            this.voltmetr1.BackColor = System.Drawing.Color.Transparent;
            this.voltmetr1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voltmetr1.BackgroundImage")));
            this.voltmetr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voltmetr1.current_Value = 0;
            this.voltmetr1.Location = new System.Drawing.Point(299, 253);
            this.voltmetr1.Name = "voltmetr1";
            this.voltmetr1.Set_Bar_min = 0;
            this.voltmetr1.Set_Bar_N_bolt = 10;
            this.voltmetr1.Set_Bar_N_not_bolt = 50;
            this.voltmetr1.Set_Bar_N_tzhifra = 10;
            this.voltmetr1.Set_Bar_step = 100D;
            this.voltmetr1.Set_Center_str = "mA";
            this.voltmetr1.Set_Value = 0;
            this.voltmetr1.Size = new System.Drawing.Size(203, 208);
            this.voltmetr1.TabIndex = 1;
            // 
            // pwr
            // 
            this.pwr.BackColor = System.Drawing.Color.Transparent;
            this.pwr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pwr.BackgroundImage")));
            this.pwr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pwr.isSided = false;
            this.pwr.Location = new System.Drawing.Point(107, 450);
            this.pwr.Name = "pwr";
            this.pwr.Set_Skin = 1;
            this.pwr.Size = new System.Drawing.Size(42, 42);
            this.pwr.State = false;
            this.pwr.TabIndex = 2;
            this.pwr.Click += new System.EventHandler(this.pwr_Click);
            // 
            // ignite
            // 
            this.ignite.BackColor = System.Drawing.Color.Transparent;
            this.ignite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ignite.BackgroundImage")));
            this.ignite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ignite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ignite.Location = new System.Drawing.Point(611, 171);
            this.ignite.Name = "ignite";
            this.ignite.Size = new System.Drawing.Size(45, 45);
            this.ignite.TabIndex = 3;
            this.ignite.Click += new System.EventHandler(this.ignite_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Transparent;
            this.stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stop.BackgroundImage")));
            this.stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.Location = new System.Drawing.Point(613, 247);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(45, 45);
            this.stop.TabIndex = 4;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // tokSHG
            // 
            this.tokSHG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.tokSHG.Location = new System.Drawing.Point(586, 354);
            this.tokSHG.Name = "tokSHG";
            this.tokSHG.Set_Type = 0;
            this.tokSHG.Set_Value = 75;
            this.tokSHG.Size = new System.Drawing.Size(100, 85);
            this.tokSHG.TabIndex = 5;
            this.tokSHG.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.tokSHG_Value_Changed);
            // 
            // bk008
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(791, 586);
            this.Controls.Add(this.tokSHG);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.voltmetr1);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.pwr);
            this.Controls.Add(this.ignite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bk008";
            this.Text = "БК-008";
            this.Controls.SetChildIndex(this.ignite, 0);
            this.Controls.SetChildIndex(this.pwr, 0);
            this.Controls.SetChildIndex(this.mode, 0);
            this.Controls.SetChildIndex(this.voltmetr1, 0);
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.stop, 0);
            this.Controls.SetChildIndex(this.tokSHG, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Voltmetr voltmetr1;
        private button ignite;
        private button stop;
        public nPosSwitch mode;
        public Potenzhiomert tokSHG;
        public tumbler pwr;
    }
}