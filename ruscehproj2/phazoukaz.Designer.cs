namespace ruscehproj2
{
    partial class phazoukaz
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
            this.PUSK = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.phaze = new System.Windows.Forms.PictureBox();
            this.phaseWires = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaze)).BeginInit();
            this.SuspendLayout();
            // 
            // PUSK
            // 
            this.PUSK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PUSK.BackColor = System.Drawing.Color.Transparent;
            this.PUSK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PUSK.CausesValidation = false;
            this.PUSK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PUSK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.PUSK.FlatAppearance.BorderSize = 0;
            this.PUSK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.PUSK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.PUSK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PUSK.Location = new System.Drawing.Point(195, 147);
            this.PUSK.Name = "PUSK";
            this.PUSK.Size = new System.Drawing.Size(36, 35);
            this.PUSK.TabIndex = 25;
            this.PUSK.UseVisualStyleBackColor = false;
            this.PUSK.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PUSK_MouseDown);
            this.PUSK.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PUSK_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // phaze
            // 
            this.phaze.BackColor = System.Drawing.Color.Transparent;
            this.phaze.Cursor = System.Windows.Forms.Cursors.Default;
            this.phaze.Location = new System.Drawing.Point(78, 135);
            this.phaze.Name = "phaze";
            this.phaze.Size = new System.Drawing.Size(60, 60);
            this.phaze.TabIndex = 26;
            this.phaze.TabStop = false;
            // 
            // phaseWires
            // 
            this.phaseWires.BackColor = System.Drawing.Color.Transparent;
            this.phaseWires.Cursor = System.Windows.Forms.Cursors.Hand;
            this.phaseWires.FlatAppearance.BorderSize = 0;
            this.phaseWires.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.phaseWires.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.phaseWires.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phaseWires.Location = new System.Drawing.Point(50, 12);
            this.phaseWires.Name = "phaseWires";
            this.phaseWires.Size = new System.Drawing.Size(198, 63);
            this.phaseWires.TabIndex = 143;
            this.phaseWires.UseVisualStyleBackColor = false;
            this.phaseWires.Click += new System.EventHandler(this.phaseWires_Click);
            // 
            // phazoukaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(100)))), ((int)(((byte)(175)))));
            this.BackgroundImage = global::ruscehproj2.Resources.phazePointer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(294, 272);
            this.Controls.Add(this.phaze);
            this.Controls.Add(this.PUSK);
            this.Controls.Add(this.phaseWires);
            this.DoubleBuffered = true;
            this.Name = "phazoukaz";
            this.Text = "Фазоуказатель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.phazoukaz_FormClosing);
            this.Load += new System.EventHandler(this.phazoukaz_Load);
            this.Controls.SetChildIndex(this.phaseWires, 0);
            this.Controls.SetChildIndex(this.PUSK, 0);
            this.Controls.SetChildIndex(this.phaze, 0);
            this.Controls.SetChildIndex(this.str, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaze)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button PUSK;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox phaze;
        private System.Windows.Forms.Button phaseWires;
    }
}