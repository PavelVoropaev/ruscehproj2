namespace ruscehproj2
{
    partial class bk005
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bk005));
            this.door = new System.Windows.Forms.Button();
            this.enter = new ruscehproj2.ground();
            this.ground = new ruscehproj2.ground();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wire = new System.Windows.Forms.Button();
            this.zeroAzSet = new ruscehproj2.Potenzhiomert();
            this.zeroDalSet = new ruscehproj2.Potenzhiomert();
            this.zeroAz = new System.Windows.Forms.Label();
            this.zeroDal = new System.Windows.Forms.Label();
            this.azOpNorm = new ruscehproj2.bulb();
            this.dalOpNorm = new ruscehproj2.bulb();
            this.azNeprNorm = new ruscehproj2.bulb();
            this.azOpBad = new ruscehproj2.bulb();
            this.dalOpBad = new ruscehproj2.bulb();
            this.azNeprBad = new ruscehproj2.bulb();
            this.azVoltage = new ruscehproj2.ground();
            this.dalVoltage = new ruscehproj2.ground();
            ((System.ComponentModel.ISupportInitialize)(this.str)).BeginInit();
            this.SuspendLayout();
            // 
            // door
            // 
            this.door.BackColor = System.Drawing.Color.Transparent;
            this.door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.door.Cursor = System.Windows.Forms.Cursors.Hand;
            this.door.FlatAppearance.BorderSize = 0;
            this.door.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.door.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.door.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.door.Location = new System.Drawing.Point(139, 177);
            this.door.Name = "door";
            this.door.Size = new System.Drawing.Size(325, 170);
            this.door.TabIndex = 141;
            this.door.UseVisualStyleBackColor = false;
            this.door.Click += new System.EventHandler(this.door_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.Color.Transparent;
            this.enter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enter.BackgroundImage")));
            this.enter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enter.Location = new System.Drawing.Point(390, 225);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(33, 35);
            this.enter.TabIndex = 142;
            this.enter.Visible = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ground.BackgroundImage")));
            this.ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ground.Location = new System.Drawing.Point(390, 266);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(33, 35);
            this.ground.TabIndex = 142;
            this.ground.Visible = false;
            this.ground.Click += new System.EventHandler(this.ground_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 143;
            this.label1.Text = "Вход ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 143;
            this.label2.Text = "Корпус";
            this.label2.Visible = false;
            // 
            // wire
            // 
            this.wire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.wire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wire.FlatAppearance.BorderSize = 0;
            this.wire.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.wire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))));
            this.wire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wire.Location = new System.Drawing.Point(470, 225);
            this.wire.Name = "wire";
            this.wire.Size = new System.Drawing.Size(92, 167);
            this.wire.TabIndex = 150;
            this.wire.UseVisualStyleBackColor = false;
            this.wire.Click += new System.EventHandler(this.wire_Click);
            // 
            // zeroAzSet
            // 
            this.zeroAzSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.zeroAzSet.Location = new System.Drawing.Point(146, 188);
            this.zeroAzSet.Name = "zeroAzSet";
            this.zeroAzSet.Set_Type = 0;
            this.zeroAzSet.Set_Value = 0;
            this.zeroAzSet.Size = new System.Drawing.Size(100, 85);
            this.zeroAzSet.TabIndex = 151;
            this.zeroAzSet.Visible = false;
            this.zeroAzSet.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.zeroAzSet_Value_Changed);
            // 
            // zeroDalSet
            // 
            this.zeroDalSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(115)))));
            this.zeroDalSet.Location = new System.Drawing.Point(240, 188);
            this.zeroDalSet.Name = "zeroDalSet";
            this.zeroDalSet.Set_Type = 0;
            this.zeroDalSet.Set_Value = 0;
            this.zeroDalSet.Size = new System.Drawing.Size(100, 85);
            this.zeroDalSet.TabIndex = 152;
            this.zeroDalSet.Visible = false;
            this.zeroDalSet.Value_Changed += new ruscehproj2.Potenzhiomert.SomeEventDelegate(this.zeroDalSet_Value_Changed);
            // 
            // zeroAz
            // 
            this.zeroAz.AutoSize = true;
            this.zeroAz.Location = new System.Drawing.Point(152, 312);
            this.zeroAz.Name = "zeroAz";
            this.zeroAz.Size = new System.Drawing.Size(94, 13);
            this.zeroAz.TabIndex = 153;
            this.zeroAz.Text = "НОЛЬ АЗИМУТА";
            this.zeroAz.Visible = false;
            // 
            // zeroDal
            // 
            this.zeroDal.AutoSize = true;
            this.zeroDal.Location = new System.Drawing.Point(252, 312);
            this.zeroDal.Name = "zeroDal";
            this.zeroDal.Size = new System.Drawing.Size(110, 13);
            this.zeroDal.TabIndex = 154;
            this.zeroDal.Text = "НОЛЬ ДАЛЬНОСТИ";
            this.zeroDal.Visible = false;
            // 
            // azOpNorm
            // 
            this.azOpNorm.BackColor = System.Drawing.Color.Transparent;
            this.azOpNorm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("azOpNorm.BackgroundImage")));
            this.azOpNorm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.azOpNorm.Location = new System.Drawing.Point(33, 103);
            this.azOpNorm.Name = "azOpNorm";
            this.azOpNorm.SetColor = "";
            this.azOpNorm.Size = new System.Drawing.Size(60, 60);
            this.azOpNorm.TabIndex = 157;
            // 
            // dalOpNorm
            // 
            this.dalOpNorm.BackColor = System.Drawing.Color.Transparent;
            this.dalOpNorm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dalOpNorm.BackgroundImage")));
            this.dalOpNorm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dalOpNorm.Location = new System.Drawing.Point(114, 103);
            this.dalOpNorm.Name = "dalOpNorm";
            this.dalOpNorm.SetColor = "";
            this.dalOpNorm.Size = new System.Drawing.Size(60, 60);
            this.dalOpNorm.TabIndex = 158;
            // 
            // azNeprNorm
            // 
            this.azNeprNorm.BackColor = System.Drawing.Color.Transparent;
            this.azNeprNorm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("azNeprNorm.BackgroundImage")));
            this.azNeprNorm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.azNeprNorm.Location = new System.Drawing.Point(33, 177);
            this.azNeprNorm.Name = "azNeprNorm";
            this.azNeprNorm.SetColor = "";
            this.azNeprNorm.Size = new System.Drawing.Size(60, 60);
            this.azNeprNorm.TabIndex = 159;
            // 
            // azOpBad
            // 
            this.azOpBad.BackColor = System.Drawing.Color.Transparent;
            this.azOpBad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("azOpBad.BackgroundImage")));
            this.azOpBad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.azOpBad.Location = new System.Drawing.Point(493, 103);
            this.azOpBad.Name = "azOpBad";
            this.azOpBad.SetColor = "";
            this.azOpBad.Size = new System.Drawing.Size(60, 60);
            this.azOpBad.TabIndex = 160;
            // 
            // dalOpBad
            // 
            this.dalOpBad.BackColor = System.Drawing.Color.Transparent;
            this.dalOpBad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dalOpBad.BackgroundImage")));
            this.dalOpBad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dalOpBad.Location = new System.Drawing.Point(404, 103);
            this.dalOpBad.Name = "dalOpBad";
            this.dalOpBad.SetColor = "";
            this.dalOpBad.Size = new System.Drawing.Size(60, 60);
            this.dalOpBad.TabIndex = 161;
            // 
            // azNeprBad
            // 
            this.azNeprBad.BackColor = System.Drawing.Color.Transparent;
            this.azNeprBad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("azNeprBad.BackgroundImage")));
            this.azNeprBad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.azNeprBad.Location = new System.Drawing.Point(493, 177);
            this.azNeprBad.Name = "azNeprBad";
            this.azNeprBad.SetColor = "";
            this.azNeprBad.Size = new System.Drawing.Size(60, 60);
            this.azNeprBad.TabIndex = 162;
            // 
            // azVoltage
            // 
            this.azVoltage.BackColor = System.Drawing.Color.Transparent;
            this.azVoltage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("azVoltage.BackgroundImage")));
            this.azVoltage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.azVoltage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.azVoltage.Location = new System.Drawing.Point(57, 280);
            this.azVoltage.Name = "azVoltage";
            this.azVoltage.Size = new System.Drawing.Size(21, 19);
            this.azVoltage.TabIndex = 163;
            this.azVoltage.Click += new System.EventHandler(this.azVoltage_Click_1);
            // 
            // dalVoltage
            // 
            this.dalVoltage.BackColor = System.Drawing.Color.Transparent;
            this.dalVoltage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dalVoltage.BackgroundImage")));
            this.dalVoltage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dalVoltage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dalVoltage.Location = new System.Drawing.Point(57, 300);
            this.dalVoltage.Name = "dalVoltage";
            this.dalVoltage.Size = new System.Drawing.Size(21, 19);
            this.dalVoltage.TabIndex = 164;
            this.dalVoltage.Click += new System.EventHandler(this.dalVoltage_Click_1);
            // 
            // bk005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(604, 423);
            this.Controls.Add(this.dalVoltage);
            this.Controls.Add(this.azVoltage);
            this.Controls.Add(this.azNeprBad);
            this.Controls.Add(this.dalOpBad);
            this.Controls.Add(this.azOpBad);
            this.Controls.Add(this.azNeprNorm);
            this.Controls.Add(this.dalOpNorm);
            this.Controls.Add(this.azOpNorm);
            this.Controls.Add(this.zeroDal);
            this.Controls.Add(this.zeroAz);
            this.Controls.Add(this.zeroDalSet);
            this.Controls.Add(this.zeroAzSet);
            this.Controls.Add(this.wire);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.door);
            this.Name = "bk005";
            this.Text = "БК-005";
            this.Load += new System.EventHandler(this.bk005_Load);
            this.Controls.SetChildIndex(this.door, 0);
            this.Controls.SetChildIndex(this.ground, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.enter, 0);
            this.Controls.SetChildIndex(this.str, 0);
            this.Controls.SetChildIndex(this.wire, 0);
            this.Controls.SetChildIndex(this.zeroAzSet, 0);
            this.Controls.SetChildIndex(this.zeroDalSet, 0);
            this.Controls.SetChildIndex(this.zeroAz, 0);
            this.Controls.SetChildIndex(this.zeroDal, 0);
            this.Controls.SetChildIndex(this.azOpNorm, 0);
            this.Controls.SetChildIndex(this.dalOpNorm, 0);
            this.Controls.SetChildIndex(this.azNeprNorm, 0);
            this.Controls.SetChildIndex(this.azOpBad, 0);
            this.Controls.SetChildIndex(this.dalOpBad, 0);
            this.Controls.SetChildIndex(this.azNeprBad, 0);
            this.Controls.SetChildIndex(this.azVoltage, 0);
            this.Controls.SetChildIndex(this.dalVoltage, 0);
            ((System.ComponentModel.ISupportInitialize)(this.str)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button door;
        private ground enter;
        private ground ground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button wire;
        private Potenzhiomert zeroAzSet;
        private Potenzhiomert zeroDalSet;
        private System.Windows.Forms.Label zeroAz;
        private System.Windows.Forms.Label zeroDal;
        private bulb azOpNorm;
        private bulb dalOpNorm;
        private bulb azNeprNorm;
        private bulb azOpBad;
        private bulb dalOpBad;
        private bulb azNeprBad;
        private ground azVoltage;
        private ground dalVoltage;
    }
}