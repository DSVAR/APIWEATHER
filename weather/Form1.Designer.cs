namespace weather
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.историяГородаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pressure = new System.Windows.Forms.Label();
            this.Max = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.Feels_like = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Набережные Челны",
            "Казань",
            "Москва",
            "Светогорск",
            "Норильск",
            "Ленск",
            "Томск",
            "Новосибирск",
            "Красноярск",
            "Новокузнецк",
            "Омск",
            "Самара",
            "Нижний Новгород",
            "Иркутск",
            "Воркута",
            "Торонто",
            "Нью Йорк",
            "Омаха",
            "Лондон",
            "Детроит"});
            this.comboBox1.Location = new System.Drawing.Point(31, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(105, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(105, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(351, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Location = new System.Drawing.Point(185, 148);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(41, 13);
            this.time.TabIndex = 11;
            this.time.Text = "label13";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.историяГородаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // историяГородаToolStripMenuItem
            // 
            this.историяГородаToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.историяГородаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.историяГородаToolStripMenuItem.Name = "историяГородаToolStripMenuItem";
            this.историяГородаToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.историяГородаToolStripMenuItem.Text = "История города";
            this.историяГородаToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.историяГородаToolStripMenuItem.Click += new System.EventHandler(this.историяГородаToolStripMenuItem_Click);
            // 
            // Pressure
            // 
            this.Pressure.AutoSize = true;
            this.Pressure.BackColor = System.Drawing.Color.Transparent;
            this.Pressure.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pressure.Location = new System.Drawing.Point(377, 316);
            this.Pressure.Name = "Pressure";
            this.Pressure.Size = new System.Drawing.Size(41, 13);
            this.Pressure.TabIndex = 27;
            this.Pressure.Text = "label12";
            this.Pressure.Click += new System.EventHandler(this.Pressure_Click);
            // 
            // Max
            // 
            this.Max.AutoSize = true;
            this.Max.BackColor = System.Drawing.Color.Transparent;
            this.Max.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Max.Location = new System.Drawing.Point(670, 359);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(41, 13);
            this.Max.TabIndex = 25;
            this.Max.Text = "label16";
            // 
            // Min
            // 
            this.Min.AutoSize = true;
            this.Min.BackColor = System.Drawing.Color.Transparent;
            this.Min.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Min.Location = new System.Drawing.Point(670, 343);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(41, 13);
            this.Min.TabIndex = 24;
            this.Min.Text = "label15";
            // 
            // Feels_like
            // 
            this.Feels_like.AutoSize = true;
            this.Feels_like.BackColor = System.Drawing.Color.Transparent;
            this.Feels_like.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Feels_like.Location = new System.Drawing.Point(670, 326);
            this.Feels_like.Name = "Feels_like";
            this.Feels_like.Size = new System.Drawing.Size(41, 13);
            this.Feels_like.TabIndex = 23;
            this.Feels_like.Text = "label14";
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.BackColor = System.Drawing.Color.Transparent;
            this.Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Temp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Temp.Location = new System.Drawing.Point(656, 259);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(101, 31);
            this.Temp.TabIndex = 22;
            this.Temp.Text = "label13";
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.BackColor = System.Drawing.Color.Transparent;
            this.speed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.speed.Location = new System.Drawing.Point(412, 287);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(41, 13);
            this.speed.TabIndex = 21;
            this.speed.Text = "label12";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Status.Location = new System.Drawing.Point(46, 298);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(67, 20);
            this.Status.TabIndex = 20;
            this.Status.Text = "label11";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(108, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 61);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::weather.Properties.Resources.Bez_imeni_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pressure);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Feels_like);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label time;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem историяГородаToolStripMenuItem;
        public System.Windows.Forms.Label Pressure;
        public System.Windows.Forms.Label Max;
        public System.Windows.Forms.Label Min;
        public System.Windows.Forms.Label Feels_like;
        public System.Windows.Forms.Label Temp;
        public System.Windows.Forms.Label speed;
        public System.Windows.Forms.Label Status;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

