namespace ruscehproj2
{
    partial class genericForm
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
            this.str = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // str
            // 
            this.str.BackColor = System.Drawing.Color.Transparent;
            this.str.BackgroundImage = global::ruscehproj2.Resources.strelka;
            this.str.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.str.Location = new System.Drawing.Point(1446, 426);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(69, 69);
            this.str.TabIndex = 0;
            this.str.TabStop = false;
            this.str.Visible = false;
            // 
            // genericForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 498);
            this.Controls.Add(this.str);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "genericForm";
            this.Text = "genericForm";
            this.Activated += new System.EventHandler(this.genericForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.genericForm_FormClosing);
            this.Load += new System.EventHandler(this.genericForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.genericForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox str;

    }
}