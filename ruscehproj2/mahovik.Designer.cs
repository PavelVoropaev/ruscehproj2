namespace ruscehproj2
{
    partial class mahovik
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
            this.potenzhiomert1 = new ruscehproj2.Potenzhiomert();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // potenzhiomert1
            // 
            this.potenzhiomert1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.potenzhiomert1.Location = new System.Drawing.Point(40, 109);
            this.potenzhiomert1.Name = "potenzhiomert1";
            this.potenzhiomert1.Set_Type = 0;
            this.potenzhiomert1.Set_Value = 50;
            this.potenzhiomert1.Size = new System.Drawing.Size(100, 85);
            this.potenzhiomert1.TabIndex = 1;
            this.potenzhiomert1.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.potenzhiomert1_Value_Changed);
            // 
            // mahovik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ruscehproj2.Resources.mahovik;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(199, 246);
            this.Controls.Add(this.potenzhiomert1);
            this.DoubleBuffered = true;
            this.Name = "mahovik";
            this.Text = "Маховик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mahovik_FormClosing);
            this.Load += new System.EventHandler(this.mahovik_Load);
            this.Controls.SetChildIndex(this.potenzhiomert1, 0);
            this.Controls.SetChildIndex(this.str, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Potenzhiomert potenzhiomert1;
    }
}