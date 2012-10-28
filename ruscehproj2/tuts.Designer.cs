namespace ruscehproj2
{
    partial class tuts
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
            this.nPosSwitch1 = new nPosSwitch.nPosSwitch();
            this.tumbler1 = new twoPosSwitch.tumbler();
            this.SuspendLayout();
            // 
            // nPosSwitch1
            // 
            this.nPosSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nPosSwitch1.Location = new System.Drawing.Point(43, 438);
            this.nPosSwitch1.Name = "nPosSwitch1";
            this.nPosSwitch1.Size = new System.Drawing.Size(105, 97);
            this.nPosSwitch1.TabIndex = 0;
            // 
            // tumbler1
            // 
            this.tumbler1.Location = new System.Drawing.Point(154, 446);
            this.tumbler1.Name = "tumbler1";
            this.tumbler1.Size = new System.Drawing.Size(111, 89);
            this.tumbler1.TabIndex = 1;
            // 
            // tuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 569);
            this.Controls.Add(this.tumbler1);
            this.Controls.Add(this.nPosSwitch1);
            this.Name = "tuts";
            this.Text = "tuts";
            this.ResumeLayout(false);

        }

        #endregion

        private nPosSwitch.nPosSwitch nPosSwitch1;
        private twoPosSwitch.tumbler tumbler1;
    }
}