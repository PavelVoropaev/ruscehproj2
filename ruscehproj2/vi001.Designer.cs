namespace ruscehproj2
{
    partial class vi001
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vi001));
            this.tumb2 = new ruscehproj2.nPosSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // tumb2
            // 
            this.tumb2.BackColor = System.Drawing.Color.Transparent;
            this.tumb2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tumb2.BackgroundImage")));
            this.tumb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tumb2.Location = new System.Drawing.Point(148, 171);
            this.tumb2.Name = "tumb2";
            this.tumb2.Size = new System.Drawing.Size(72, 81);
            this.tumb2.Step = 0;
            this.tumb2.TabIndex = 1;
            this.tumb2.Click += new System.EventHandler(this.tumb2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ПАД.ОТР.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ОТР.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "ПАД.";
            // 
            // wire
            // 
            this.wire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.wire.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wire.BackgroundImage")));
            this.wire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wire.FlatAppearance.BorderSize = 0;
            this.wire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.wire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.wire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wire.Location = new System.Drawing.Point(314, 309);
            this.wire.Name = "wire";
            this.wire.Size = new System.Drawing.Size(90, 49);
            this.wire.TabIndex = 149;
            this.wire.UseVisualStyleBackColor = false;
            this.wire.Click += new System.EventHandler(this.wire_Click);
            // 
            // vi001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 354);
            this.Controls.Add(this.wire);
            this.Controls.Add(this.tumb2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "vi001";
            this.Text = "ВИ-001";
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tumb2, 0);
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.wire, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private nPosSwitch tumb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button wire;
    }
}