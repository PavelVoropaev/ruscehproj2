namespace ruscehproj2
{
    partial class splashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.hlp_on = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(259, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(894, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите режим проверки работоспособности радиомаяка РСБН-4Н";
            this.label1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "1. ПОДГОТОВКА И ПЕРВИЧНОЕ ВКЛЮЧЕНИЕ РСБН-4Н",
            "     1.1 Подготовка к включению ",
            "     1.2 Первичное включение аппаратуры радиомаяка ",
            "2. ОПРЕДЕЛЕНИЕ РАБОТОСПОСОБНОСТИ И ЗАПУСК САР СКОРОСТИ ВРАЩЕНИЯ  АЗИМУТАЛЬНОЙ  АН" +
                "ТЕННЫ.",
            "    2.1 Методика определения работоспособности  и запуск  САР скорости  врещения " +
                "  азимутальной антенны.",
            "3. ВКЛЮЧЕНИЕ И ПРОВЕРКА РАБОТОСПОСОБНОСТИ ИНА И БЛОКОВ БК-006 и БК-007.",
            "4. СОВМЕЩЕНИЕ ЭЛЕКТРОМАГНИТНЫХ ДАТЧИКОВ",
            "5. ВКЛЮЧЕНИЕ И ПРОВЕРКА РАБОТОСПОСОБНОСТИ ПЕРЕДАЮЩИХ УСТРОЙСТВ",
            "    5.1 Методика работы с прибором измерителя проходящей импульсной мощности (ИПИ" +
                "М)",
            "    5.2 Методика работы с прибором измерителя проходящей непрерывкой мощности (ИП" +
                "НМ)",
            "    5.3 Методика работы с блоком допускового контроля (БК-005)  ",
            "6. ВКЛЮЧЕНИЕ И ПРОВЕРКА РАБОТОСПОСОБНОСТИ ПРИЕМНЫХ УСТРОЙСТВ",
            "   6.1 Проверка чувствительности приемных устройств по касательному  сигналу при " +
                "соотношении сигнал/шум, равном 2",
            "   6.2 Проверка чувствительности приемника по срабатыванию  дешифраторов",
            "   6.3 Проверка работоспособности гетеродинов ",
            "   6.4 Проверка работоспособности приемных устройств с помощью  блока БК-008",
            "   6.5 Включение и проверка работоспособности контрольных приемных устройств БР-0" +
                "03",
            "7. ВКЛЮЧЕНИЕ И ПРОВЕРКА РАБОТОСПОСОБНОСТИ АППАРАТУРЫ КОНТРОЛЯ АЗИМУТА И ДАЛЬНОСТИ" +
                "",
            "8. ВКЛЮЧЕНИЕ И ПРОВЕРКА РАБОТОСПОСОБНОСТИ ИКО ",
            "   8.1 Проверка АФТ и антенн ",
            "   8.2 Включение и проверка работоспособности  системы ТУ-ТС.",
            "9. РАБОТА РАДИОМАЯКА В РЕЖИМЕ МЕСТНЫЙ РЕМОНТ",
            "   9.1 Использование режима МЕСТНЫЙ РЕМОНТ",
            "   9.2 Включения и выключения аппаратуры в  режиме МЕСТНЫЙ РЕМОНТ",
            "10. РАБОТА РАДИОМАЯКА В РЕЖИМЕ УПРАВЛЕНИЯ МЕСТНАЯ РАБОТА ",
            "   10.1 Использование режима МЕСТНАЯ РАБОТА ",
            "   10.2 Включения и выключения аппаратуры в режиме  МЕСТНАЯ РАБОТА ",
            "11. РАБОТА РАДИОМАЯКА В РЕЖИМЕ УПРАВЛЕНИЯ ДИСТАНЦИОННАЯ РАБОТА",
            "   11.1 Использование режима ДИСТАНЦИОННАЯ РАБОТА ",
            "   11.2 Перечень сигналов обратной сигнализации и команд ",
            "   11.3 Включение и выключению радиомаяка с пульта дистанционного управления",
            "12. ХАРАКТЕРНЫЕ НЕИСПРАВНОСТИ И РЕМОНТ.",
            "   12.1 Методы отыскания неисправностей",
            "   12.2 Характерные неисправности, ремонт блоков и узлов"});
            this.listBox1.Location = new System.Drawing.Point(237, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(866, 614);
            this.listBox1.TabIndex = 3;
            this.listBox1.Visible = false;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start.Location = new System.Drawing.Point(601, 725);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(98, 33);
            this.start.TabIndex = 0;
            this.start.Text = "ПУСК";
            this.start.UseVisualStyleBackColor = true;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(205, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(468, 28);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ТРЕНИРОВКА работы боевого расчета РСБН-4Н";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(702, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(452, 28);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "КОНТРОЛЬ работы боевого расчета РСБН-4Н ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // hlp_on
            // 
            this.hlp_on.AutoSize = true;
            this.hlp_on.BackColor = System.Drawing.Color.Transparent;
            this.hlp_on.Checked = true;
            this.hlp_on.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hlp_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hlp_on.ForeColor = System.Drawing.Color.Cornsilk;
            this.hlp_on.Location = new System.Drawing.Point(541, 690);
            this.hlp_on.Name = "hlp_on";
            this.hlp_on.Size = new System.Drawing.Size(221, 29);
            this.hlp_on.TabIndex = 4;
            this.hlp_on.Text = "Включить помощь";
            this.hlp_on.UseVisualStyleBackColor = false;
            this.hlp_on.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(785, 823);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Нажми любую кнопку для продолжения";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.BackgroundImage = global::ruscehproj2.Resources.cross;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Location = new System.Drawing.Point(1139, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 31);
            this.close.TabIndex = 7;
            this.close.TabStop = false;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button3_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Transparent;
            this.about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("about.BackgroundImage")));
            this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Location = new System.Drawing.Point(1099, -1);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(34, 31);
            this.about.TabIndex = 7;
            this.about.TabStop = false;
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // splashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(100)))), ((int)(((byte)(175)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1164, 780);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.about);
            this.Controls.Add(this.close);
            this.Controls.Add(this.hlp_on);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.listBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "splashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.splashScreen_Activated);
            this.Click += new System.EventHandler(this.splashScreen_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.splashScreen_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.CheckBox hlp_on;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button about;
    }
}