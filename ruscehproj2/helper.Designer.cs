namespace ruscehproj2
{
    partial class helper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helper));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hlpText = new System.Windows.Forms.Label();
            this.auxInfo = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.signal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error_count = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 133);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // hlpText
            // 
            this.hlpText.Location = new System.Drawing.Point(149, 12);
            this.hlpText.Name = "hlpText";
            this.hlpText.Size = new System.Drawing.Size(276, 131);
            this.hlpText.TabIndex = 1;
            // 
            // auxInfo
            // 
            this.auxInfo.AutoSize = true;
            this.auxInfo.Location = new System.Drawing.Point(210, 151);
            this.auxInfo.Name = "auxInfo";
            this.auxInfo.Size = new System.Drawing.Size(41, 13);
            this.auxInfo.TabIndex = 4;
            this.auxInfo.Text = "auxinfo";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(350, 146);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 5;
            this.Next.Text = "Далее";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Visible = false;
            this.Next.Click += new System.EventHandler(this.Next_Click_1);
            // 
            // signal
            // 
            this.signal.AutoSize = true;
            this.signal.Location = new System.Drawing.Point(12, 138);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(41, 13);
            this.signal.TabIndex = 4;
            this.signal.Text = "auxinfo";
            this.signal.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "auxinfo";
            this.label1.Visible = false;
            // 
            // error_count
            // 
            this.error_count.AutoSize = true;
            this.error_count.ForeColor = System.Drawing.Color.Red;
            this.error_count.Location = new System.Drawing.Point(279, 151);
            this.error_count.Name = "error_count";
            this.error_count.Size = new System.Drawing.Size(59, 13);
            this.error_count.TabIndex = 4;
            this.error_count.Text = "Ошибки: 0";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(340, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "GOD MODE";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // helper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 170);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.error_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signal);
            this.Controls.Add(this.auxInfo);
            this.Controls.Add(this.hlpText);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "helper";
            this.Opacity = 0.9D;
            this.ShowInTaskbar = false;
            this.Text = "ПОМОЩЬ (Перенесите в удобное место)";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.helper_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.helper_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label hlpText;
        private System.Windows.Forms.Label auxInfo;
        public System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label signal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error_count;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}